using AutoMapper;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class AwardService : IAwardService
    {
        private IMapper _mapper;
        private readonly IBaseService<Award> _awardService;        
        public AwardService(IBaseService<Award> awardService , IMapper mapper)
        {           
            _mapper = mapper;
            _awardService = awardService;
        }
        public void Dispose()
        {
            this.Dispose();
        }

        public async Task<bool> Update(VMAward award)
        {
            List<Award> awards = await _awardService.GetAll().AsNoTracking().ToListAsync<Award>(); // AsNoTracking is important to update.
            var vmAwards = _mapper.Map<List<VMAward>>(awards);
            VMAward vMAward = vmAwards.Where(x => x.Id == award.Id).FirstOrDefault();
            vMAward.Name = award.Name;
            await _awardService.UpdateAsync(vMAward);  
            return true;
        }
    }
}
