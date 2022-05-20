namespace ProjetoFinalAliare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Alunos",
                c => new
                    {
                        Matricula = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        CPF = c.String(),
                        Endereco = c.String(),
                        CEP = c.String(),
                        Complemento = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Matricula);
            
            CreateTable(
                "public.Cursos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Matricula_Matricula = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Alunos", t => t.Matricula_Matricula)
                .Index(t => t.Matricula_Matricula);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Cursos", "Matricula_Matricula", "public.Alunos");
            DropIndex("public.Cursos", new[] { "Matricula_Matricula" });
            DropTable("public.Cursos");
            DropTable("public.Alunos");
        }
    }
}
