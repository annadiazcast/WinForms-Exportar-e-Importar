using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class Acciones
    {
        private List<Alumno> alumnolist = new List<Alumno>();
        Correo correo= new Correo();

        public List<Alumno> Mostrar()
        {
            try
            {
                return alumnolist;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }

        public bool ExportaraExcel()
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Alumnos");

                // Encabezados
                worksheet.Cell(1, 0).Value = "Nombre";
                worksheet.Cell(1, 2).Value = "Edad";
                worksheet.Cell(1, 3).Value = "Carrera";
                worksheet.Cell(1, 4).Value = "Matricula";
                worksheet.Cell(1, 5).Value = "Fecha Nacimiento";

                // Datos
                for (int i = 0; i < alumnolist.Count; i++)
                {
                    var alumno = alumnolist[i];
                    worksheet.Cell(i + 2, 1).Value = alumno.Nombre;
                    worksheet.Cell(i + 2, 2).Value = alumno.Edad;
                    worksheet.Cell(i + 2, 3).Value = alumno.Carrera;
                    worksheet.Cell(i + 2, 4).Value = alumno.Matricula;
                    worksheet.Cell(i + 2, 5).Value = alumno.Fechanacimiento.ToShortDateString();
                }

                // Ruta al escritorio
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "ListaDeAlumnos.xlsx");

                workbook.SaveAs(filePath);
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

        public bool ImportarDeExcel()
        {
            try
            {
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(desktopPath, "ListaAlumnos.xlsx");

                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("Alumnos");

                    var rows = worksheet.RowsUsed().Skip(1); // Saltar los encabezados

                    alumnolist.Clear(); // Limpiar la lista antes de importar nuevos datos

                    foreach (var row in rows)
                    {
                        var nombre = row.Cell(1).Value.ToString();

                        // Usar TryParse para evitar excepciones en la conversión
                        int edad = 0;
                        int.TryParse(row.Cell(2).Value.ToString(), out edad); // Intentar convertir a entero

                        var carrera = row.Cell(3).Value.ToString();

                        int matricula = 0;
                        int.TryParse(row.Cell(4).Value.ToString(), out matricula); // Intentar convertir a entero

                        DateTime fechaIngreso;
                        DateTime.TryParse(row.Cell(5).Value.ToString(), out fechaIngreso); // Intentar convertir a DateTime

                        // Agregar el Alumno solo si la conversión fue exitosa
                        alumnolist.Add(new Alumno(nombre, edad, carrera, matricula, fechaIngreso));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }

    }
}
