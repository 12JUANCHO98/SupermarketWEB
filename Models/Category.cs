﻿using SupermarketWEB.Models;

public class Category
{
    public int Id { get; set; } // Será la llave primaria

    public string Name { get; set; }

    public string? Description { get; set; }

    public ICollection<Product> Products { get; set; } // Propiedad de navegación
}