using ClassTrack.Domain.Entities;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ClassTrack.Utilidades
{
    public class InformeProfesor : IDocument
    {
        private readonly Profesor profesor;

        public InformeProfesor(Profesor profesor)
        {
            this.profesor = profesor;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(40);
                page.Header().Text($"INFORME POR PROFESOR: {profesor.Nombre}")
                             .SemiBold().FontSize(18).AlignCenter();

                page.Content().Column(col =>
                {
                    col.Spacing(10);

                    col.Item().Text($"Área de Conocimiento: {profesor.AreaConocimiento.Nombre}");
                    col.Item().Text($"Departamento: {profesor.AreaConocimiento.Departamento.Nombre}");
                    col.Item().Text($"Despacho: {profesor.Despacho}");

                    col.Item().Text("Asignaturas que Imparte Curso 2000/01:")
                        .Bold().FontSize(14);

                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("Código").Bold();
                            header.Cell().Element(CellStyle).Text("Nombre").Bold();
                        });

                        //foreach (var a in profesor.Asignaturas)
                        //{
                        //    table.Cell().Element(CellStyle).Text(a.Codigo);
                        //    table.Cell().Element(CellStyle).Text(a.Nombre);
                        //}
                    });

                    col.Item().Text("Horario de Consultas:")
                        .Bold().FontSize(14);

                    col.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(CellStyle).Text("Día").Bold();
                            header.Cell().Element(CellStyle).Text("Horario").Bold();
                        });

                        //foreach (var c in profesor.Consultas)
                        //{
                        //    table.Cell().Element(CellStyle).Text(c.Dia);
                        //    table.Cell().Element(CellStyle).Text(c.Hora);
                        //}
                    });
                });

                page.Footer().AlignCenter().Text(x =>
                {
                    x.Span("Generado por la aplicación WinForms");
                });
            });
        }

        IContainer CellStyle(IContainer container) =>
            container.Padding(5).Border(1).BorderColor(Colors.Grey.Lighten2);
    }

}
