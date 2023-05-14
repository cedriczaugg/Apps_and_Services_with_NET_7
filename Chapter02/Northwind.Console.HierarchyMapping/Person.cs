﻿using System.ComponentModel.DataAnnotations;

namespace Northwind.Console.HierarchyMapping;

public class Person
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(40)]
    public string? Name { get; set; }
}