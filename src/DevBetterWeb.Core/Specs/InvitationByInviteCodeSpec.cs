﻿using Ardalis.Specification;
using DevBetterWeb.Core.Entities;

namespace DevBetterWeb.Core.Specs;

public class InvitationByInviteCodeSpec : Specification<Invitation>, ISingleResultSpecification
{
  public InvitationByInviteCodeSpec(string inviteCode)
  {
    Query.Where(invite => invite.InviteCode == inviteCode);
  }
}
