using RentMeApp.DAL;
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
        /// Initializes a new instance of the <see cref="MemberControllerX"/> class.
        /// </summary>
        public MemberController()
        {
            this._memberSource = new MemberDAL();
        }

        /// <summary>
        /// Gets the member information x.
        /// </summary>
        /// <returns></returns>
        public List<Member> GetMemberInfo()
        {
            return this._memberSource.GetMemberInfo();
        }

        public int InsertNewMember(Member member)
        {
           return this._memberSource.InsertNewMember(member);
        }

    }
}
