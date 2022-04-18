namespace LibraryClass {
    public class Biblioteca {
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
    }
}