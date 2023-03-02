using AutoMapper;
using UniversalMusic.Management.Application.Dtos;
using UniversalMusic.Management.Application.Interfaces;
using UniversalMusic.Management.Entity;
using UniversalMusic.Management.Repository.Interfaces;

namespace UniversalMusic.Management.Application.Implementations
{
    public class DiscsApplication : IDiscsApplication
    {
        private IDiscsRepository discsRepository;
        private IMapper mapper;

        public DiscsApplication(IDiscsRepository discsRepository, IMapper mapper)
        {
            this.discsRepository= discsRepository;
            this.mapper= mapper;
        }
        public async Task<List<DiscForListDto>> GetDiscs()
        {
            var discs = await discsRepository.GetDiscs();
            var discsDto = mapper.Map<List<DiscForListDto>>(discs);
            return discsDto;
        }
        public async Task<DiscForDetailDto> GetDisc(int id)
        {
            var disc = await discsRepository.GetDisc(id);
            var discDto = mapper.Map<DiscForDetailDto>(disc);
            return discDto;
        }
        public async Task InsertDisc(DiscForCreateDto discForCreateDto)
        {
            var discEntity = mapper.Map<Disc>(discForCreateDto);
            await discsRepository.InsertDisc(discEntity);
        }

        public async Task UpdateDisc(int id, DiscForEditDto discForEditDto)
        {
            var discEntity = await discsRepository.GetDisc(id);
            mapper.Map(discForEditDto, discEntity);
            await discsRepository.UpdateDisc(discEntity);
        }
    }
}
