using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

namespace YSKProje.ToDo.Web.ViewComponents
{
    public class CTable : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IGorevService _gorevService;

        public CTable(IMapper mapper,IGorevService gorevService)
        {
            _mapper = mapper;
            _gorevService = gorevService;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla()));
        }

    }
}
