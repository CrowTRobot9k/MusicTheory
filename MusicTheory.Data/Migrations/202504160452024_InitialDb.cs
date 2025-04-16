namespace MusicTheory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChordNote",
                c => new
                    {
                        ChordNoteId = c.Int(nullable: false, identity: true),
                        ChordId = c.Int(nullable: false),
                        Interval = c.Int(),
                    })
                .PrimaryKey(t => t.ChordNoteId)
                .ForeignKey("dbo.Chord", t => t.ChordId)
                .Index(t => t.ChordId);
            
            CreateTable(
                "dbo.Chord",
                c => new
                    {
                        ChordId = c.Int(nullable: false, identity: true),
                        ChordName = c.String(),
                    })
                .PrimaryKey(t => t.ChordId);
            
            CreateTable(
                "dbo.MusicKey",
                c => new
                    {
                        MusicKeyId = c.Int(nullable: false, identity: true),
                        MusicKey = c.String(),
                    })
                .PrimaryKey(t => t.MusicKeyId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        NoteName = c.String(),
                    })
                .PrimaryKey(t => t.NoteId);
            
            CreateTable(
                "dbo.ScaleNote",
                c => new
                    {
                        ScaleNoteId = c.Int(nullable: false, identity: true),
                        ScaleId = c.Int(nullable: false),
                        Interval = c.Int(),
                    })
                .PrimaryKey(t => t.ScaleNoteId)
                .ForeignKey("dbo.Scale", t => t.ScaleId)
                .Index(t => t.ScaleId);
            
            CreateTable(
                "dbo.Scale",
                c => new
                    {
                        ScaleId = c.Int(nullable: false, identity: true),
                        ScaleName = c.String(),
                    })
                .PrimaryKey(t => t.ScaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScaleNote", "ScaleId", "dbo.Scale");
            DropForeignKey("dbo.ChordNote", "ChordId", "dbo.Chord");
            DropIndex("dbo.ScaleNote", new[] { "ScaleId" });
            DropIndex("dbo.ChordNote", new[] { "ChordId" });
            DropTable("dbo.Scale");
            DropTable("dbo.ScaleNote");
            DropTable("dbo.Note");
            DropTable("dbo.MusicKey");
            DropTable("dbo.Chord");
            DropTable("dbo.ChordNote");
        }
    }
}
