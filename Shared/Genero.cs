using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrud.Shared
{
    public class Genero
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        
        
        
        
    }
}