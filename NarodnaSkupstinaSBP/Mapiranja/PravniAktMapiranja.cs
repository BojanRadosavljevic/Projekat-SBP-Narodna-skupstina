using FluentNHibernate.Mapping;
using NarodnaSkupstinaSBP.Entiteti;

namespace NarodnaSkupstinaSBP.Mapiranja
{
    public class PravniAktMapiranja : ClassMap<PravniAkt>
    {
        public PravniAktMapiranja()
        {
            Table("PRAVNI_AKT");
            Id(x => x.IDPravnogAkta, "ID_PRAVNOG_AKTA").GeneratedBy.TriggerIdentity();
            DiscriminateSubClassesOnColumn("TIP_AKTA");
            DiscriminateSubClassesOnColumn("PREDLAGACI_AKTA");

        }
    }

    public class ZakonMapiranja : SubclassMap<Zakon>
    {
        public ZakonMapiranja()
        {
            DiscriminatorValue("ZAKON");
        }
    }
    public class DeklaracijaMapiranja : SubclassMap<Deklaracija>
    {
        public DeklaracijaMapiranja()
        {
            DiscriminatorValue("DEKLARACIJA");
        }
    }
    public class PreporukaMapiranja : SubclassMap<Preporuka>
    {
        public PreporukaMapiranja()
        {
            DiscriminatorValue("PREPORUKA");
        }
    }
    public class OdlukaMapiranja : SubclassMap<Odluka>
    {
        public OdlukaMapiranja()
        {
            DiscriminatorValue("ODLUKA");
        }
    }
    public class TumacenjeMapiranja : SubclassMap<Tumacenje>
    {
        public TumacenjeMapiranja()
        {
            DiscriminatorValue("TUMACENJE");
        }
    }
    public class BiraciMapiranja : SubclassMap<Biraci>
    {
        public BiraciMapiranja()
        {
            DiscriminatorValue("BIRACI");
            Map(x => x.BrojBiraca).Column("BROJ_BIRACA");
        }
    }
    public class VladaMapiranja : SubclassMap<Vlada>
    {
        public VladaMapiranja()
        {
            DiscriminatorValue("VLADA");
        }
    }
    public class PoslaniciMapiranja : SubclassMap<Poslanici>
    {
        public PoslaniciMapiranja()
        {
            DiscriminatorValue("POSLANICI");
            HasManyToMany(x => x.Predlozili).Table("PREDLOZIO").ParentKeyColumn("ID_PRAVNOG_AKTA")
                                            .ChildKeyColumn("ID_POSLANIKA").Cascade.All().Inverse();
        }
    }


}
