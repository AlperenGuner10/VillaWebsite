using AutoMapper;
using Villa.DTO.Dtos.BannerDtos;
using Villa.DTO.Dtos.ContactDtos;
using Villa.DTO.Dtos.CounterDtos;
using Villa.DTO.Dtos.DealDtos;
using Villa.DTO.Dtos.FeatureDtos;
using Villa.DTO.Dtos.MessageDtos;
using Villa.DTO.Dtos.ProductDtos;
using Villa.DTO.Dtos.QuestDtos;
using Villa.DTO.Dtos.VideoDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mapping
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<ResultBannerDto, Banner>().ReverseMap();
			CreateMap<CreateBannerDto, Banner>().ReverseMap();
			CreateMap<UpdateBannerDto, Banner>().ReverseMap();

			CreateMap<ResultContactDto, Contact>().ReverseMap();
			CreateMap<CreateContactDto, Contact>().ReverseMap();
			CreateMap<UpdateContactDto, Contact>().ReverseMap();

			CreateMap<ResultCounterDto, Counter>().ReverseMap();
			CreateMap<CreateCounterDto, Counter>().ReverseMap();
			CreateMap<UpdateCounterDto, Counter>().ReverseMap();

			CreateMap<ResultDealDto, Deal>().ReverseMap();
			CreateMap<CreateDealDto, Deal>().ReverseMap();
			CreateMap<UpdateDealDto, Deal>().ReverseMap();

			CreateMap<ResultFeatureDto, Feature>().ReverseMap();
			CreateMap<CreateFeatureDto, Feature>().ReverseMap();
			CreateMap<UpdateFeatureDto, Feature>().ReverseMap();

			CreateMap<ResultMessageDto, Message>().ReverseMap();
			CreateMap<CreateMessageDto, Message>().ReverseMap();
			CreateMap<UpdateMessageDto, Message>().ReverseMap();

			CreateMap<ResultProductDto, Product>().ReverseMap();
			CreateMap<CreateProductDto, Product>().ReverseMap();
			CreateMap<UpdateProductDto, Product>().ReverseMap();

			CreateMap<ResultQuestDto, Quest>().ReverseMap();
			CreateMap<CreateQuestDto, Quest>().ReverseMap();
			CreateMap<UpdateQuestDto, Quest>().ReverseMap();

			CreateMap<ResultVideoDto, Video>().ReverseMap();
			CreateMap<CreateVideoDto, Video>().ReverseMap();
			CreateMap<UpdateVideoDto, Video>().ReverseMap();
		}
	}
}
