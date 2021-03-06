using JetBrains.Annotations;
using MAVN.Service.CustomerProfile.Client.Models.Enums;

namespace MAVN.Service.CustomerProfile.Client.Models.Responses
{
    /// <summary>
    /// Represents response of referral friend request.
    /// </summary>
    [PublicAPI]
    public class ReferralFriendProfileResponse
    {
        /// <summary>
        /// Contains referral friend profile.
        /// </summary>
        public ReferralFriendProfile Data { get; set; }

        /// <summary>
        /// The error code of operation with referral friend contract.
        /// </summary>
        public ReferralFriendProfileErrorCodes ErrorCode { get; set; }
    }
}
