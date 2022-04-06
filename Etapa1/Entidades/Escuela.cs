namespace CoreEscuela.Entidades
{
    class Escuela{
        
        public string Nombre{get;set;}
        public int AñoCreacion{get;set;}

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public Escuela(string nombre,int año){
            this.Nombre=nombre;
            this.AñoCreacion=año;
        }

        public Escuela(string nombre,int año,string pais="",string ciudad=""){
            this.Nombre=nombre;
            this.AñoCreacion=año;
            this.Pais=pais;
            this.Ciudad=ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela}\nPais: {Pais} Ciudad: {Ciudad}";
        }
    }
    
}