using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabhHane.Server.Data.Models;
using TabhHane.Shared.DTO;

namespace TabhHane.Server.Services.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfing = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
            IMapper mapper = mappingConfing.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<Banka, BankaDTO>().ReverseMap();

            CreateMap<BankaHareket, BankaHareketDTO>()
                .ForMember(c => c.HesapKodu, x => x.MapFrom(y => y.Banka.HesapKodu))
                .ForMember(c => c.HesapIsmi, x => x.MapFrom(y => y.Banka.HesapIsmi))
                .ForMember(c => c.Bankasi, x => x.MapFrom(y => y.Banka.Bankasi))
                .ForMember(c => c.Sube, x => x.MapFrom(y => y.Banka.Sube))
                .ForMember(c => c.CariKodu, x => x.MapFrom(y => y.Cari.CariKodu))
                .ForMember(c => c.CariAdi, x => x.MapFrom(y => y.Cari.CariAdi))
                .ForMember(c => c.YetkiliKisi, x => x.MapFrom(y => y.Cari.YetkiliKisi))
                .ForMember(c => c.FaturaUnvani, x => x.MapFrom(y => y.Cari.FaturaUnvani));

            CreateMap<BankaHareketDTO, BankaHareket>();

            CreateMap<Cari, CariDTO>().ReverseMap();

            CreateMap<Depo, DepoDTO>().ReverseMap();

            CreateMap<Fis, FisDTO>()
             .ForMember(c => c.HesapKodu, x => x.MapFrom(y => y.Banka.HesapKodu))
             .ForMember(c => c.HesapIsmi, x => x.MapFrom(y => y.Banka.HesapIsmi))
             .ForMember(c => c.Bankasi, x => x.MapFrom(y => y.Banka.Bankasi))
             .ForMember(c => c.Sube, x => x.MapFrom(y => y.Banka.Sube))
             .ForMember(c => c.IbanNo, x => x.MapFrom(y => y.Banka.IbanNo))
             .ForMember(c => c.CariKodu, x => x.MapFrom(y => y.Cari.CariKodu))
             .ForMember(c => c.CariAdi, x => x.MapFrom(y => y.Cari.CariAdi))
             .ForMember(c => c.YetkiliKisi, x => x.MapFrom(y => y.Cari.YetkiliKisi))
             .ForMember(c => c.FaturaUnvani, x => x.MapFrom(y => y.Cari.FaturaUnvani))
             .ForMember(c => c.DepoKodu, x => x.MapFrom(y => y.Depo.DepoKodu))
             .ForMember(c => c.DepoAdi, x => x.MapFrom(y => y.Depo.DepoAdi))
             .ForMember(c => c.PersonelAdi, x => x.MapFrom(y => y.Personel.PersonelAdi))
             .ForMember(c => c.PersonelKodu, x => x.MapFrom(y => y.Personel.PersonelKodu));

            CreateMap<FisDTO, Fis>();

            CreateMap<HizliSatis, HizliSatisDTO>().ReverseMap();

            CreateMap<HizliSatisGrup, HizliSatisGrupDTO>().ReverseMap();

            CreateMap<Indirim, IndirimDTO>().ReverseMap();

            CreateMap<Kasa, KasaDTO>().ReverseMap();

            CreateMap<KasaHareket, KasaHareketDTO>()
               .ForMember(c => c.KasaAdi, x => x.MapFrom(y => y.Kasa.KasaAdi))
               .ForMember(c => c.KasaKodu, x => x.MapFrom(y => y.Kasa.KasaKodu))
               .ForMember(c => c.OdemeTuruKodu, x => x.MapFrom(y => y.OdemeTuru.OdemeTuruKodu))
               .ForMember(c => c.OdemeTuruAdi, x => x.MapFrom(y => y.OdemeTuru.OdemeTuruAdi))
               .ForMember(c => c.CariKodu, x => x.MapFrom(y => y.Cari.CariKodu))
               .ForMember(c => c.CariAdi, x => x.MapFrom(y => y.Cari.CariAdi));

            CreateMap<KasaHareketDTO, KasaHareket>();

            CreateMap<Kod, KodDTO>().ReverseMap();

            CreateMap<Kullanici, KullaniciDTO>().ReverseMap();

            CreateMap<KullaniciRol, KullaniciRolDTO>()
             .ForMember(c => c.KullaniciAdi, x => x.MapFrom(y => y.Kullanici.KullaniciAdi));

            CreateMap<KullaniciRolDTO, KullaniciRol>();

            CreateMap<OdemeTuru, OdemeTuruDTO>().ReverseMap();

            CreateMap<Personel, PersonelDTO>().ReverseMap();

            CreateMap<PersonelHareket, PersonelHareketDTO>().ReverseMap();

            CreateMap<SirketBilgi, SirketBilgiDTO>().ReverseMap();

            CreateMap<Stok, StokDTO>().ReverseMap();

            CreateMap<StokHareket, StokHareketDTO>()
               .ForMember(c => c.StokKodu, x => x.MapFrom(y => y.Stok.StokKodu))
               .ForMember(c => c.StokAdi, x => x.MapFrom(y => y.Stok.StokAdi))
               .ForMember(c => c.Barkod, x => x.MapFrom(y => y.Stok.Barkod))
               .ForMember(c => c.BarkodTuru, x => x.MapFrom(y => y.Stok.BarkodTuru))
               .ForMember(c => c.Birimi, x => x.MapFrom(y => y.Stok.Birimi))
               .ForMember(c => c.DepoKodu, x => x.MapFrom(y => y.Depo.DepoKodu))
               .ForMember(c => c.DepoAdi, x => x.MapFrom(y => y.Depo.DepoAdi));

            CreateMap<StokHareketDTO, StokHareket>();

            CreateMap<Tanim, TanimDTO>().ReverseMap();
        }
    }
}
