﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace apiCaptar;
[Table("cad_usuario")]
public class Usuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome")]
    public string Nome { get; set; }

    [Column("email")]
    public string email
    {
        get; set;
    }

    [Column("senha")]
    public string senha
    {
        get; set;
    }



}