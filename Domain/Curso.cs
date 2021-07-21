using System.Collections.Generic;
using System;
namespace Domain
{
    public class Curso
    {
        public Guid CursoId{get;set;}
        public string Titulo{get;set;}
        public string Descripcion{get;set;}
        public DateTime? FechaPublicacion{get;set;}
        public byte[] FotoPortada{get;set;}
        public DateTime? FechaCreacion{get;set;}
    }
}