if (this.progression_data.receiver_rank > 1) {
    PlayerGUI.Instance.RankChangeScreen.ResetState(this.progression_data.receiver_rank);
    ReceiverOnScreenMessage.Instance.ClearMessageQueue();
    string uistring = Locale.GetUIString(this.GetReceiverRankName(this.progression_data.receiver_rank));
    this.EvaluateNextLoadout();
    PlayerGUI.Instance.RankChangeScreen.SetMainText(Locale.FormatUIString(LocaleUIString.RS_DEMOTED, new object[]
    {
                            uistring
    }));
    string hurtInfoString = PlayerInfoMessages.GetHurtInfoString(this.rcs.active_player_data.session_data.death_info.cause_of_death);
    string deathInfoString = PlayerInfoMessages.GetDeathInfoString(this.rcs.active_player_data.session_data.death_info.cause_of_death);
    PlayerGUI.Instance.RankChangeScreen.SetSecondaryText(deathInfoString + "\n" + hurtInfoString);
    PlayerGUI.Instance.RankChangeScreen.SetGunModel(this.next_loadout.gun);
    int old_rank;
    PlayerGUI.Instance.RankChangeScreen.OnRankChange(this.progression_data.receiver_rank, old_rank);
}