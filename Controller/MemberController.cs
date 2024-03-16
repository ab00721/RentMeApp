﻿using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;
namespace RentMeApp.Controller
{
    /// <summary>
    /// Controller class for Members
    /// </summary>
    public class MemberController
    {
        private readonly MemberDAL _memberSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// </summary>
        public MemberController()
        {
            this._memberSource = new MemberDAL();
        }

        /// <summary>
        /// Gets the member information.
        /// </summary>
        /// <returns></returns>
        public List<Member> GetMemberInfo()
        {
            return this._memberSource.GetMemberInfo();
        }

        /// <summary>
        /// Inserts the new member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public int InsertNewMember(Member member)
        {
           return this._memberSource.InsertNewMember(member);
        }

        /// <summary>
        /// Updates an existing member.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns></returns>
        public int UpdateExistingMember(Member member)
        {
            return this._memberSource.UpdateExistingMember(member);
        }

    }
}
