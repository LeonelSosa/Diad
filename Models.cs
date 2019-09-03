using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Diad.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        { }
      public DbSet<Producto> Productos{get; set;}
      public DbSet<Categoria> Categorias{get; set;}
      public DbSet<Cliente> Clientes{get; set;
      
      }
    }

   

    
    

    public class Producto{

    
          
      public int ProductoId{get; set;}
        public int Precio { get; set; }

        public string titulo { get; set; }


        public int CategoriaId { get; set; }

        public Categoria categoria{get; set;}

        public string Descripcion { get; set; }
       }

        public class Categoria
        {

            public int CategoriaId { get; set; }

            public string Titulo { get; set; }

            public string Caracteristicas { get; set; }

            public int Precio { get; set; }
             public List<Producto> Producto { get; set; }


        }

        public class Cliente
        {

            public int ClienteId {get; set;}

            public string Nombre {get ; set;}

            public string Apellido {get; set;}

            public string Username {get; set;}
            
           
        }









    }















