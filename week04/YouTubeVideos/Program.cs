using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Review del Nuevo Smartphone X", "TechGuru", 420);
        video1.AddComment(new Comment("Ana", "Muy buena explicación, gracias."));
        video1.AddComment(new Comment("Carlos", "¿Sabes si viene en color rojo?"));
        video1.AddComment(new Comment("María", "Me compré uno gracias a este review."));
        _videos.Add(video1);

        Video video2 = new Video("Unboxing Cámara GoPro HERO10", "Aventurero", 300);
        video2.AddComment(new Comment("Luis", "¡Qué ganas de probarla en mis viajes!"));
        video2.AddComment(new Comment("Sofía", "Muy completo el unboxing."));
        video2.AddComment(new Comment("Jorge", "¿Qué accesorios incluye?"));
        _videos.Add(video2);

        Video video3 = new Video("Tutorial Photoshop para Principiantes", "DiseñoFacil", 600);
        video3.AddComment(new Comment("Valeria", "Excelente tutorial, muy claro."));
        video3.AddComment(new Comment("Mateo", "¿Podrías hacer uno avanzado?"));
        video3.AddComment(new Comment("Lucía", "Gracias por compartir tus conocimientos."));
        _videos.Add(video3);

        Video video4 = new Video("Top 5 Gadgets para el Hogar", "Innovatech", 480);
        video4.AddComment(new Comment("Pedro", "Quiero comprar el gadget #3, se ve genial."));
        video4.AddComment(new Comment("Elena", "Muy útil, gracias por las recomendaciones."));
        video4.AddComment(new Comment("Javier", "¿Dónde puedo conseguir el gadget #5?"));
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
    }
}