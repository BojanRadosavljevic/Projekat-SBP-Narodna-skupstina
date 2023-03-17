namespace NarodnaSkupstinaSBP.Entiteti
{
    public class Prostorija
    {
        public virtual int ProstorijaID { get; set; }
        public virtual int Sprat { get; set; }
        public virtual int Broj { get; set; }
        public virtual PoslanickaGrupa Dodeljena { get; set; }
        public Prostorija()
        { }
        public override int GetHashCode()
        {
            return this.Sprat.GetHashCode() + this.Broj.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
