using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;
using System.Data;
using System;

namespace LogicLayer
{
    public class ReportManager
    {
        public ReportManager()
        {

        }

        //La fecha se genera aqui dentro junto con la hora
        public void ImprimirEgreso(int RUT,int montoEgresado,string Motivo,string nombreVendedor)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Archivos pdf (*.pdf)|*.pdf";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    #region Documento Copia Tienda
                    Document doc = new Document();
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Path.GetFullPath(dialog.FileName), FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("C:\\Users\\Falva\\Desktop\\Frutos de Elqui\\logo.png");
                    jpg.ScaleToFit(150f, 150f);
                    jpg.Alignment = Element.ALIGN_CENTER;
                    doc.Add(jpg);
                    doc.Add(new Paragraph("                                                              "));
                    Chunk c1 = new Chunk("Reporte de Egresos para Frutos de Elqui", FontFactory.GetFont("dax-black", 20));
                    c1.SetUnderline(0.5f, -1.5f);
                    Chunk c2 = new Chunk("Copia Tienda", FontFactory.GetFont("dax-black", 16));
                    var lineBreak = new Chunk(new LineSeparator());
                   
                    var phara = new Paragraph(c1)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(phara);
                    var phara2 = new Paragraph(c2)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(phara2);
                    doc.Add(lineBreak);
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    #region Egreso Motivo y weas
                    var fraseCompleta = new Paragraph("Con fecha " + System.DateTime.Now.ToString("dd/MM/yyyy") + " a la hora de " +
                        System.DateTime.Now.ToString("HH:mm:ss")+" el Vendedor "+nombreVendedor+" con R.U.T. registrado en la base de datos de " +
                        RUT+" ha realizado un Egreso de Dinero con el monto de "+montoEgresado.ToString("C0")+" dado el motivo "+Motivo+"." +
                        "\n Se extiende este reporte de egreso para ser firmado por el vendedor y el que recibe el egreso.") {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(fraseCompleta);
                    doc.Add(new Paragraph("                                                                   "));
                    doc.Add(new Paragraph("                                                                 "));
                    doc.Add(new DottedLineSeparator());
                    #endregion
                    #region Espacio entre evento y Firmas
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    #endregion
                    var firmaAutorizante = new Paragraph("__________________________                                               _________________________");
                    var rutAutorizante = new Paragraph("              " + nombreVendedor + "                           " +
                        "                                       Recibí Conforme");
                    doc.Add(firmaAutorizante);
                    doc.Add(rutAutorizante);
                    doc.Close();
                    #endregion

                    SaveFileDialog dialogCopia = new SaveFileDialog();
                    dialogCopia.Filter = "Archivos pdf (*.pdf)|*.pdf";
                    dialogCopia.FilterIndex = 1;
                    dialogCopia.RestoreDirectory = true;
                    if (dialogCopia.ShowDialog() == DialogResult.OK)
                    {
                        #region Documento Copia Cliente
                        Document docCopia = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(docCopia, new FileStream(Path.GetFullPath(dialogCopia.FileName), FileMode.Create));
                        docCopia.Open();
                        iTextSharp.text.Image jpgCopia = iTextSharp.text.Image.GetInstance("C:\\Users\\Falva\\Desktop\\Frutos de Elqui\\logo.png");
                        jpgCopia.ScaleToFit(150f, 150f);
                        jpgCopia.Alignment = Element.ALIGN_CENTER;
                        docCopia.Add(jpgCopia);
                        docCopia.Add(new Paragraph("                                                              "));
                        Chunk c1Copia = new Chunk("Reporte de Egresos para Frutos de Elqui", FontFactory.GetFont("dax-black", 20));
                        c1Copia.SetUnderline(0.5f, -1.5f);
                        Chunk c2Copia = new Chunk("Copia Cliente", FontFactory.GetFont("dax-black", 16));
                        var lineBreakCopia = new Chunk(new LineSeparator());

                        var pharaCopia = new Paragraph(c1Copia)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        docCopia.Add(pharaCopia);
                        var phara2Copia = new Paragraph(c2Copia)
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        docCopia.Add(phara2Copia);
                        docCopia.Add(lineBreakCopia);
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        var fraseCompletaCopia = new Paragraph("Con fecha " + System.DateTime.Now.ToString("dd/MM/yyyy") + " a la hora de " +
                            System.DateTime.Now.ToString("HH:mm:ss") + " el Vendedor " + nombreVendedor + " con R.U.T. registrado en la base de datos de " +
                            RUT + " ha realizado un Egreso de Dinero con el monto de " + montoEgresado.ToString("C0") + " dado el motivo " + Motivo + "." +
                            "\n Se extiende este reporte de egreso para ser firmado por el vendedor y el que recibe el egreso.")
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        docCopia.Add(fraseCompletaCopia);
                        docCopia.Add(new Paragraph("                                                                   "));
                        docCopia.Add(new Paragraph("                                                                 "));
                        docCopia.Add(new DottedLineSeparator());
                        #region Espacio entre evento y Firmas
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        docCopia.Add(new Paragraph("                                                              "));
                        #endregion
                        var firmaAutorizanteCopia = new Paragraph("__________________________                                               _________________________");
                        var rutAutorizanteCopia = new Paragraph("              " + nombreVendedor + "                           " +
                            "                                       Recibí Conforme");
                        docCopia.Add(firmaAutorizanteCopia);
                        docCopia.Add(rutAutorizanteCopia);
                        docCopia.Close();

                        #endregion

                        MessageBox.Show("Reporte Creado Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Operacion cancelada por el Usuario", "Error");
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(null,e.Message,"Error");
            }
        }

        public void ImprimirIngreso(int RUT, int montoIngresado, string Motivo, string nombreVendedor)
        {
            #region Copia Original
            #endregion

            #region Copia Cliente
            #endregion
        }

        public void ImprimirIngresosEgresosPorRut(int RUT,string fechaInicio,string fechaFinal,DataTable table)
        {

        }

        public void ImprimirIngresosPorDia(int RUT, string fechaInicio, string fechaFinal,DataTable table)
        {

        }

        public void ImprimirInventario(int RUT, string Nombre, DataTable table)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Archivos pdf (*.pdf)|*.pdf";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    #region Parte Estandar
                    Document doc = new Document();
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(Path.GetFullPath(dialog.FileName), FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("C:\\Users\\Falva\\Desktop\\Frutos de Elqui\\logo.png");
                    jpg.ScaleToFit(150f, 150f);
                    jpg.Alignment = Element.ALIGN_CENTER;
                    doc.Add(jpg);
                    doc.Add(new Paragraph("                                                              "));
                    Chunk c1 = new Chunk("Reporte de Inventario Válido para Frutos de Elqui", FontFactory.GetFont("dax-black", 20));
                    c1.SetUnderline(0.5f, -1.5f);
                    Chunk c2 = new Chunk("Copia Tienda", FontFactory.GetFont("dax-black", 16));
                    var lineBreak = new Chunk(new LineSeparator());

                    var phara = new Paragraph(c1)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(phara);
                    var phara2 = new Paragraph(c2)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(phara2);
                    doc.Add(lineBreak);
                    doc.Add(new Paragraph("                                                              "));
                    doc.Add(new Paragraph("                                                              "));
                    #endregion

                    #region Aqui va la Tabla

                    #endregion
                    #region Firmas
                    var firmaAutorizante = new Paragraph("__________________________                                               _________________________");
                    var rutAutorizante = new Paragraph("              " + Nombre + "                           " +
                        "                                       Recibí Conforme");
                    doc.Add(firmaAutorizante);
                    doc.Add(rutAutorizante);
                    #endregion

                    doc.Close();
                }
                else
                {
                    MessageBox.Show(null, "Operación cancelada por el Usuario", "Cancelación");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
