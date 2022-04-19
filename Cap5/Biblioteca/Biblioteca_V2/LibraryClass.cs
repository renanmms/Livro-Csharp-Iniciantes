using System;

namespace LibraryClass
{
    public class Biblioteca
    {
        private string _Titulo;
        private string _Autor;
        private int _Paginas;
        private bool _Status;

        // Construtor sem parâmetros
        public Biblioteca(){

        }

        // Construtor com parâmetros
        public Biblioteca(string Titulo, string Autor, int Paginas, bool Status){
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;
        }

        public string Titulo {
            get {return _Titulo;} set { _Titulo = value;}
        }

        public string Autor {
            get {return _Autor;} set {_Autor = value;}
        }
        public int Paginas 
        {
            get {return _Paginas;} set {_Paginas = value;}
        }

        public bool Status 
        {
            get{ return _Status;} set {_Status = value;}
        }

        public virtual void Descarte()
        {
            _Titulo = "O Livro foi Doado";
        }
    }

    public class Revistas : Biblioteca {
        private int _MesPublicacao;
        private int _AnoPublicacao;

        public Revistas(int MesPublicacao, int AnoPublicacao){
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }

        public int MesPublicacao {
            get {return _MesPublicacao;}
            set {_MesPublicacao = value;}
        }

        public int AnoPublicacao {
            get {return _AnoPublicacao;} 
            set {_AnoPublicacao = value;}
        }

        public override void Descarte()
        {
            this.Titulo = "A Revista foi Reciclada";
        }
    }

    public class Fotos : Revistas
    {
        // Propriedades da Classe
        private string _Tipo;

        public Fotos(string Tipo): base (0,0)
        {
            _Tipo = Tipo;
        }
        public string Tipo { 
            get {return _Tipo;}
            set {_Tipo = value;}   
        }

        public override void Descarte()
        {
            this.Titulo = "A Foto foi Destruida";
        }
    }

}