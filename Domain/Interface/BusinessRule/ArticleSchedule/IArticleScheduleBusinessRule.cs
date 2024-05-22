using CrossCutting.DataSession;
using Domain.DTO;
using Domain.Interface.BusinessRule.Base;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace Domain.Interface.BusinessRule.ArticleSchedule
{
    public interface IArticleScheduleBusinessRule : IBaseBusinessRule<IArticleRepository, ArticleScheduleDTO, ArticleScheduleViewModel, InputCreateArticleScheduleViewModel>
    {
        void Delete(DataSession dataSession, long id);
    }
}
