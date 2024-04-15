using MagicVilla_VillaAPI.Models.Dto;
using System.Collections.Generic;

namespace MagicVilla_VillaAPI.Data
{
    public class VillasStore
    {
       public static List<VillaDTO> VillasList = new List<VillaDTO> {
             new VillaDTO{Id=1, Name="Pool view"},
             new VillaDTO{Id=2, Name="Beach view"}
             };
    }
}
