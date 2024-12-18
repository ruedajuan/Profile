using CapaDatos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace Santa_Ana_Sistema
{
    public partial class FormVentas : Form
    {
        public int nroVenta=0;

        public FormVentas(int nroVenta)
        {
            InitializeComponent();
            this.nroVenta = nroVenta;
            
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Modelo m1 = new Modelo();
            labelCliente.Text = m1.obtenerNombreCliente(nroVenta.ToString());
            label16.Text = m1.obtenerDomicilioCliente(nroVenta.ToString());
            label15.Text = m1.obtenerLocalidadCliente(nroVenta.ToString());
            cargarTabla(nroVenta.ToString());
            textBox1.Text = "$" + m1.mostrarTotalDetalleVentas(nroVenta.ToString()).ToString();
            label19.Text =  "000"+ nroVenta.ToString();
            panel23.AutoScroll = true;
        }

        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarDetalleVentas(dato);


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //imrprimir
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Guardar remito como";
                saveFileDialog.FileName = "remito.pdf"; // Nombre sugerido para el archivo

                // Si el usuario selecciona una ubicación válida
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Llamar al método para crear el PDF y pasar la ruta seleccionada
                    CrearRemitoPDF(saveFileDialog.FileName);
                    MessageBox.Show("El remito ha sido generado correctamente.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void CrearRemitoPDF(string filePath)
        {
            // Crear el documento
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Abrir el documento
            doc.Open();

            // Agregar el marco negro a toda la hoja
            PdfContentByte canvas = writer.DirectContent;
            Rectangle pageBorder = new Rectangle(doc.PageSize);
            pageBorder.Left += doc.LeftMargin - 10;   // Ajustar borde izquierdo
            pageBorder.Right -= doc.RightMargin - 10; // Ajustar borde derecho
            pageBorder.Top -= doc.TopMargin - 10;     // Ajustar borde superior
            pageBorder.Bottom += doc.BottomMargin - 10; // Ajustar borde inferior
            pageBorder.BorderWidth = 2f; // Grosor del borde
            pageBorder.BorderColor = BaseColor.BLACK; // Color del borde
            pageBorder.Border = Rectangle.BOX; // Bordes en todos los lados

            // Dibujar el borde
            canvas.Rectangle(pageBorder);

            // Definir fuentes
            iTextSharp.text.Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Font normalFont2 = FontFactory.GetFont(FontFactory.TIMES, 10);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Encabezado: "Documento no válido como factura" con la "X" centrada y logo
            PdfPTable headerTable2 = new PdfPTable(1);
            headerTable2.WidthPercentage = 100;


            // Imagen de la "X"
            string xImagePath = "C:\\Users\\admin\\source\\repos\\Santa_Ana_Sistema\\Santa_Ana_Sistema\\Capturax.jpg"; // Coloca aquí la ruta de la imagen de la "X"
            iTextSharp.text.Image xImage = iTextSharp.text.Image.GetInstance(xImagePath);
            xImage.ScaleToFit(50f, 50f);
            xImage.Alignment = Element.ALIGN_CENTER;
            PdfPCell xImageCell = new PdfPCell(xImage);
            xImageCell.HorizontalAlignment = Element.ALIGN_CENTER;
            xImageCell.Border = Rectangle.NO_BORDER;
            headerTable2.AddCell(xImageCell);

            // Agregar el número de remito
            PdfPCell remitoNumberCell = new PdfPCell(new Phrase("REMITO Nº " + label19.Text , boldFont));
            remitoNumberCell.HorizontalAlignment = Element.ALIGN_CENTER;
            remitoNumberCell.Border = Rectangle.NO_BORDER;
            headerTable2.AddCell(remitoNumberCell);

            doc.Add(headerTable2);



            // Espacio vacío
            doc.Add(new Paragraph("\n"));




            // Crear una tabla para el encabezado (imagen + datos del cliente y datos adicionales)
            PdfPTable headerTable = new PdfPTable(2);
            headerTable.WidthPercentage = 100;
            headerTable.SetWidths(new float[] { 1f, 2f });

            // Agregar la imagen del logo
            string logoPath = "C:\\Users\\admin\\source\\repos\\Santa_Ana_Sistema\\Santa_Ana_Sistema\\Logo.jpg"; // Coloca aquí la ruta de tu logo
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
            logo.ScaleToFit(80f, 80f);

            PdfPCell logoCell = new PdfPCell(logo);
            logoCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            headerTable.AddCell(logoCell);

            // Crear una tabla interna para organizar los datos en filas dentro de la segunda celda
            PdfPTable clientDataSubTable = new PdfPTable(2);
            clientDataSubTable.WidthPercentage = 100;
            clientDataSubTable.SetWidths(new float[] { 3f, 3f });

            // Agregar la primera columna (datos del cliente)
            PdfPCell dirCell = new PdfPCell(new Paragraph("Dir: Santa Maria de Oro 844", normalFont2));
            dirCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(dirCell);
            PdfPCell cuitCell = new PdfPCell(new Paragraph("C.U.I.T Nº: 20-34301057-6", normalFont2));
            cuitCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(cuitCell);

            PdfPCell celCell = new PdfPCell(new Paragraph("Cel: 3624134224", normalFont2));
            celCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(celCell);
            PdfPCell fechaIncCell = new PdfPCell(new Paragraph("Fecha Inc.: 09/2012", normalFont2));
            fechaIncCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(fechaIncCell);


            // Agregar la segunda columna (datos adicionales)
            PdfPCell telCell = new PdfPCell(new Paragraph("Tel: 3624425526", normalFont2));
            telCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(telCell);
            PdfPCell atpCell = new PdfPCell(new Paragraph("A.T.P   Nº: 20-34301057-6", normalFont2));
            atpCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(atpCell);
            PdfPCell mailCell = new PdfPCell(new Paragraph("mail: santaana.fabrica@gmail.com", normalFont2));
            mailCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(mailCell);

            PdfPCell localidadCell = new PdfPCell(new Paragraph("(3500) Resistencia - Chaco", normalFont2));
            localidadCell.Border = Rectangle.NO_BORDER;
            clientDataSubTable.AddCell(localidadCell);

            // Crear una celda contenedora para la subtabla
            PdfPCell clientDataCell = new PdfPCell(clientDataSubTable);
            clientDataCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            headerTable.AddCell(clientDataCell);

            // Agregar la tabla completa al documento
            doc.Add(headerTable);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Tabla para los datos del remito (Cliente, Dirección, Localidad, etc.)
            PdfPTable dataTable = new PdfPTable(4);
            dataTable.WidthPercentage = 100;
            dataTable.SetWidths(new float[] { 1f, 2f, 1f, 2f });

            dataTable.AddCell(new PdfPCell(new Phrase("Cliente:", boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase(labelCliente.Text, normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase("Fecha:", boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase(labelFecha.Text, normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

            dataTable.AddCell(new PdfPCell(new Phrase("Dirección:", boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase(label16.Text, normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase("Localidad:", boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            dataTable.AddCell(new PdfPCell(new Phrase(label15.Text, normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

            doc.Add(dataTable);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Tabla de productos
            PdfPTable productTable = new PdfPTable(4);
            productTable.WidthPercentage = 100;
            productTable.SetWidths(new float[] { 1f, 3f, 1f, 1f });

            // Encabezados
            productTable.AddCell(new PdfPCell(new Phrase("Cantidad", boldFont)));
            productTable.AddCell(new PdfPCell(new Phrase("Producto", boldFont)));
            productTable.AddCell(new PdfPCell(new Phrase("Precio Unitario", boldFont)));
            productTable.AddCell(new PdfPCell(new Phrase("SubTotal", boldFont)));

            // Recorrer el DataGridView para agregar las filas a la tabla
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null) // Verificar que la fila no esté vacía
                {
                    productTable.AddCell(row.Cells[0].Value.ToString()); // Cantidad
                    productTable.AddCell(row.Cells[1].Value.ToString()); // Producto
                    productTable.AddCell(row.Cells[2].Value.ToString()); // Precio Unitario
                    productTable.AddCell(row.Cells[3].Value.ToString()); // Subtotal
                }
            }

            doc.Add(productTable);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Total
            PdfPTable totalTable = new PdfPTable(2);
            totalTable.WidthPercentage = 100;
            totalTable.SetWidths(new float[] { 3f, 1f });

            totalTable.AddCell(new PdfPCell(new Phrase("", boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            totalTable.AddCell(new PdfPCell(new Phrase("Total:  " + textBox1.Text, boldFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

            doc.Add(totalTable);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Sección de observaciones
            PdfPTable observationsTable = new PdfPTable(1);
            observationsTable.WidthPercentage = 100;
            observationsTable.AddCell(new PdfPCell(new Phrase("Observaciones: \n\n", boldFont)) { Border = Rectangle.NO_BORDER });
            observationsTable.AddCell(new PdfPCell(new Phrase(".", normalFont)) { Border = Rectangle.BOX });
            observationsTable.AddCell(new PdfPCell(new Phrase(".", normalFont)) { Border = Rectangle.BOX });
            observationsTable.AddCell(new PdfPCell(new Phrase(".", normalFont)) { Border = Rectangle.BOX });
            doc.Add(observationsTable);

            // Espacio vacío
            doc.Add(new Paragraph("\n"));

            // Sección de "Recibí conforme"
            PdfPTable signTable = new PdfPTable(1);
            signTable.WidthPercentage = 100;
            signTable.AddCell(new PdfPCell(new Phrase("  Recibí conforme:", boldFont)) { Border = Rectangle.NO_BORDER });
            signTable.AddCell(new PdfPCell(new Phrase("\n", boldFont)) { Border = Rectangle.NO_BORDER });
            signTable.AddCell(new PdfPCell(new Phrase("\n", boldFont)) { Border = Rectangle.NO_BORDER });
            signTable.AddCell(new PdfPCell(new Phrase("       ...........................", normalFont)) { Border = Rectangle.NO_BORDER });
            signTable.AddCell(new PdfPCell(new Phrase("       Firma del Cliente", normalFont)) { Border = Rectangle.NO_BORDER });
            doc.Add(signTable);

            // Cerrar el documento
            doc.Close();
        }

    }
}
