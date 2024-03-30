using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    /// <summary>
    /// Controller class for Members
    /// </summary>
    public class MemberController
    {
        private readonly AppSession _session;
        private readonly MemberDAL _memberSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// </summary>
        public MemberController(AppSession session)
        {
            _session = session;
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
        /// <returns>The number of rows affected by the update</returns>
        public int UpdateExistingMember(Member member)
        {
            return this._memberSource.UpdateExistingMember(member);
        }

        /// <summary>
        /// Gets a member by ID.
        /// </summary>
        /// <param name="id">The ID of the member.</param>
        /// <returns>The member with the given ID.</returns>
        public Member GetMemberByID(int id)
        {
            return this._memberSource.GetMemberByID(id);
        }

        /// <summary>
        /// Gets all members.
        /// </summary>
        /// <returns>A list of all members</returns>
        public List<Member> GetAllMembers()
        {
            return this._memberSource.GetMemberInfo();
        }

        public void ShowMenu()
        {
            MemberView view = new MemberView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
