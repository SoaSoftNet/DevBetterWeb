﻿using Ardalis.Specification;
using DevBetterWeb.Core.Entities;

namespace DevBetterWeb.Core.Specs;

public class MemberByUserIdSpec : Specification<Member>, ISingleResultSpecification
{
  public MemberByUserIdSpec(string userId)
  {
    Query.Where(member => member.UserId == userId);
  }
}
