using AutoMapper;
using FashionHexa.DTO;
using FashionHexa.Entities;
namespace FashionHexa.Profiles
{
    public class NotficationProfile
    {
        public NotficationProfile() 
        {
            CreateMap<Notification, NotificationDTO>();
            CreateMap<NotificationDTO, Notification>();
        }
    }
}
