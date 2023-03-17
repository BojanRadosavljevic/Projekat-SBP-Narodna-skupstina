using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;
namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class PoslanikMapiranja : ClassMap<Poslanik>
    {
        public PoslanikMapiranja()
        {
            Table("POSLANIK");

            Id(x => x.IDPoslanika, "ID_POSLANIKA").GeneratedBy.Assigned();

            
            Map(x => x.JMBG, "JMBG");
            Map(x => x.LicnoIme, "LIME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.ImeRoditelja, "IME_RODITELJA");
            Map(x => x.MestoRodjenja, "MESTO_ROĐENJA");
            Map(x => x.DatumRodjenja, "DATUM_ROĐENJA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.MestoStanovanja, "MESTO_STANOVANJA");
            Map(x => x.IzbornaLista, "IZBORNA_LISTA");
            References(x => x.JeClanGrupe).Column("IME_POSLANICKE_GRUPE").LazyLoad();

            HasManyToMany(x => x.JeDeo).Table("JE_DEO").ParentKeyColumn("ID_POSLANIKA").ChildKeyColumn("ID_RADNOG_TELA");
            HasManyToMany(x => x.PredlazeAkt).Table("PREDLOZIO").ParentKeyColumn("ID_POSLANIKA")
                                            .ChildKeyColumn("ID_PRAVNOG_AKTA");
            HasManyToMany(x => x.ZahtevaoSednicu).Table("JE_ZAHTEVAO").ParentKeyColumn("ID_POSLANIKA").ChildKeyColumn("ID_SEDNICE");
        }
    }

}

