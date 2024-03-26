﻿using BusinessRule.Base;
using Domain.DTO;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Domain.ViewModel;

namespace BusinessRule
{
    public class RoleBusinessRule : BaseBusinessRule<IRoleRepository, RoleDTO, RoleViewModel>, IRoleBusinessRule 
    {
        public RoleBusinessRule(IRoleRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
