namespace Telegram.Bot.Types;

/// <summary>This object represents a service message about the completion of a giveaway without public winners.</summary>
public partial class GiveawayCompleted
{
    /// <summary>Number of winners in the giveaway</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public int WinnerCount { get; set; }

    /// <summary><em>Optional</em>. Number of undistributed prizes</summary>
    public int? UnclaimedPrizeCount { get; set; }

    /// <summary><em>Optional</em>. Message with the giveaway that was completed, if it wasn't deleted</summary>
    public Message? GiveawayMessage { get; set; }

    /// <summary><em>Optional</em>. <see langword="true"/>, if the giveaway is a Telegram Star giveaway. Otherwise, currently, the giveaway is a Telegram Premium giveaway.</summary>
    public bool IsStarGiveaway { get; set; }
}
