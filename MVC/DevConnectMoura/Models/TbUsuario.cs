using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnectMoura.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E61648C9D0980", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0A51FC82EF", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id_usuario")]
    public int IdUsuario { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(50)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_usuario")]
    [StringLength(150)]
    public string? FotoPerfilUsuario { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtida> TbCurtida { get; set; } = new List<TbCurtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("IdSeguindo")]
    [InverseProperty("IdSeguindo")]
    public virtual ICollection<TbUsuario> IdSeguidor { get; set; } = new List<TbUsuario>();

    [ForeignKey("IdSeguidor")]
    [InverseProperty("IdSeguidor")]
    public virtual ICollection<TbUsuario> IdSeguindo { get; set; } = new List<TbUsuario>();
}
