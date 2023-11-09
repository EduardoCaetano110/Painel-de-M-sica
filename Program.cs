Banda djonga = new Banda("Djonga");

Album albumDoDjonga = new Album("Nu");

Musica musica1 = new Musica(djonga, "Nós")
{
    Duracao = 314,
    Disponivel = true,
};

Musica musica2 = new Musica(djonga, "Ó Quem Chega")
{
    Duracao = 333,
    Disponivel = false,

};

albumDoDjonga.AdicionarMusica(musica1);
albumDoDjonga.AdicionarMusica(musica2);
djonga.AdicionarAlbum(albumDoDjonga);

musica1.ExibirFichaTenica();
musica2.ExibirFichaTenica();

albumDoDjonga.ExibirMusicasDoAlbum();
djonga.ExibirDiscografia();

