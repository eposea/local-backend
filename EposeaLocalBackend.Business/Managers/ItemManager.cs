using AutoMapper;
using EposeaLocalBackend.Core.Interfaces.Managers;
using EposeaLocalBackend.Core.Interfaces.Repositories;
using EposeaLocalBackend.gRPC.Proto.Item;
using System.Linq;
using System.Threading.Tasks;

namespace EposeaLocalBackend.Business.Managers
{
    public class ItemManager : IItemManager
    {
        private readonly IItemRepository itemRepository;
        public ItemManager(IItemRepository itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
        }

        public Item GetItem(GetItemRequest request)
        {
            var items = itemRepository.GetAll();
            return items.FirstOrDefault(item => item.Id == request.Id);
        }

    }
}
