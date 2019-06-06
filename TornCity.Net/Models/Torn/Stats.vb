Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Stats
        Inherits TornResource

        <JsonProperty("stats")>
        Public Property Stats As StatsList
    End Class

    Public Class StatsList
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("users_total")>
        Public Property UsersTotal As Long
        <JsonProperty("users_male")>
        Public Property UsersMale As Long
        <JsonProperty("users_female")>
        Public Property UsersFemale As Long
        <JsonProperty("users_marriedcouples")>
        Public Property UsersMarriedcouples As Long
        <JsonProperty("users_daily")>
        Public Property UsersDaily As Long
        <JsonProperty("total_users_logins")>
        Public Property TotalUsersLogins As Long
        <JsonProperty("total_users_playtime")>
        Public Property TotalUsersPlaytime As String
        <JsonProperty("job_army")>
        Public Property JobArmy As Long
        <JsonProperty("job_grocer")>
        Public Property JobGrocer As Long
        <JsonProperty("job_medical")>
        Public Property JobMedical As Long
        <JsonProperty("job_casino")>
        Public Property JobCasino As Long
        <JsonProperty("job_education")>
        Public Property JobEducation As Long
        <JsonProperty("job_law")>
        Public Property JobLaw As Long
        <JsonProperty("job_company")>
        Public Property JobCompany As Long
        <JsonProperty("job_none")>
        Public Property JobNone As Long
        <JsonProperty("crimes")>
        Public Property Crimes As Long
        <JsonProperty("jailed")>
        Public Property Jailed As Long
        <JsonProperty("money_onhand")>
        Public Property MoneyOnhand As Long
        <JsonProperty("money_average")>
        Public Property MoneyAverage As Long
        <JsonProperty("money_citybank")>
        Public Property MoneyCitybank As Long
        <JsonProperty("items")>
        Public Property Items As Long
        <JsonProperty("events")>
        Public Property Events As Long
        <JsonProperty("points_total")>
        Public Property PointsTotal As Long
        <JsonProperty("points_market")>
        Public Property PointsMarket As Long
        <JsonProperty("points_averagecost")>
        Public Property PointsAveragecost As Long
        <JsonProperty("points_bought")>
        Public Property PointsBought As Long
        <JsonProperty("total_points_boughttotal")>
        Public Property TotalPointsBoughttotal As Long
        <JsonProperty("total_attacks_won")>
        Public Property TotalAttacksWon As Long
        <JsonProperty("total_attacks_lost")>
        Public Property TotalAttacksLost As Long
        <JsonProperty("total_attacks_stalemated")>
        Public Property TotalAttacksStalemated As Long
        <JsonProperty("total_attacks_runaway")>
        Public Property TotalAttacksRunaway As Long
        <JsonProperty("total_attacks_hits")>
        Public Property TotalAttacksHits As Long
        <JsonProperty("total_attacks_misses")>
        Public Property TotalAttacksMisses As Long
        <JsonProperty("total_attacks_criticalhits")>
        Public Property TotalAttacksCriticalhits As Long
        <JsonProperty("total_attacks_roundsfired")>
        Public Property TotalAttacksRoundsfired As Long
        <JsonProperty("total_attacks_stealthed")>
        Public Property TotalAttacksStealthed As Long
        <JsonProperty("total_attacks_moneymugged")>
        Public Property TotalAttacksMoneymugged As Long
        <JsonProperty("total_attacks_respectgained")>
        Public Property TotalAttacksRespectgained As Long
        <JsonProperty("total_items_marketbought")>
        Public Property TotalItemsMarketbought As Long
        <JsonProperty("total_items_bazaarbought")>
        Public Property TotalItemsBazaarbought As Long
        <JsonProperty("total_items_auctionswon")>
        Public Property TotalItemsAuctionswon As Long
        <JsonProperty("total_items_sent")>
        Public Property TotalItemsSent As Long
        <JsonProperty("total_trades")>
        Public Property TotalTrades As Long
        <JsonProperty("total_items_bazaarincome")>
        Public Property TotalItemsBazaarincome As Long
        <JsonProperty("total_items_cityfinds")>
        Public Property TotalItemsCityfinds As Long
        <JsonProperty("total_items_dumpfinds")>
        Public Property TotalItemsDumpfinds As Long
        <JsonProperty("total_items_dumped")>
        Public Property TotalItemsDumped As Long
        <JsonProperty("total_jail_jailed")>
        Public Property TotalJailJailed As Long
        <JsonProperty("total_jail_busted")>
        Public Property TotalJailBusted As Long
        <JsonProperty("total_jail_busts")>
        Public Property TotalJailBusts As Long
        <JsonProperty("total_jail_bailed")>
        Public Property TotalJailBailed As Long
        <JsonProperty("total_jail_bailcosts")>
        Public Property TotalJailBailcosts As Long
        <JsonProperty("total_hospital_trips")>
        Public Property TotalHospitalTrips As Long
        <JsonProperty("total_hospital_medicalitemsused")>
        Public Property TotalHospitalMedicalitemsused As Long
        <JsonProperty("total_hospital_revived")>
        Public Property TotalHospitalRevived As Long
        <JsonProperty("total_mails_sent")>
        Public Property TotalMailsSent As Long
        <JsonProperty("total_mails_sent_friends")>
        Public Property TotalMailsSentFriends As Long
        <JsonProperty("total_mails_sent_faction")>
        Public Property TotalMailsSentFaction As Long
        <JsonProperty("total_mails_sent_company")>
        Public Property TotalMailsSentCompany As Long
        <JsonProperty("total_mails_sent_spouse")>
        Public Property TotalMailsSentSpouse As Long
        <JsonProperty("total_classifiedads_placed")>
        Public Property TotalClassifiedadsPlaced As Long
        <JsonProperty("total_bounty_placed")>
        Public Property TotalBountyPlaced As Long
        <JsonProperty("total_bounty_rewards")>
        Public Property TotalBountyRewards As Long
        <JsonProperty("total_travel_all")>
        Public Property TotalTravelAll As Long
        <JsonProperty("total_travel_argentina")>
        Public Property TotalTravelArgentina As Long
        <JsonProperty("total_travel_mexico")>
        Public Property TotalTravelMexico As Long
        <JsonProperty("total_travel_dubai")>
        Public Property TotalTravelDubai As Long
        <JsonProperty("total_travel_hawaii")>
        Public Property TotalTravelHawaii As Long
        <JsonProperty("total_travel_japan")>
        Public Property TotalTravelJapan As Long
        <JsonProperty("total_travel_unitedkingdom")>
        Public Property TotalTravelUnitedkingdom As Long
        <JsonProperty("total_travel_southafrica")>
        Public Property TotalTravelSouthafrica As Long
        <JsonProperty("total_travel_switzerland")>
        Public Property TotalTravelSwitzerland As Long
        <JsonProperty("total_travel_china")>
        Public Property TotalTravelChina As Long
        <JsonProperty("total_travel_canada")>
        Public Property TotalTravelCanada As Long
        <JsonProperty("total_travel_caymanislands")>
        Public Property TotalTravelCaymanislands As Long
        <JsonProperty("total_drugs_used")>
        Public Property TotalDrugsUsed As Long
        <JsonProperty("total_drugs_overdosed")>
        Public Property TotalDrugsOverdosed As Long
        <JsonProperty("total_drugs_cannabis")>
        Public Property TotalDrugsCannabis As Long
        <JsonProperty("total_drugs_ecstacy")>
        Public Property TotalDrugsEcstacy As Long
        <JsonProperty("total_drugs_ketamine")>
        Public Property TotalDrugsKetamine As Long
        <JsonProperty("total_drugs_lsd")>
        Public Property TotalDrugsLsd As Long
        <JsonProperty("total_drugs_opium")>
        Public Property TotalDrugsOpium As Long
        <JsonProperty("total_drugs_shrooms")>
        Public Property TotalDrugsShrooms As Long
        <JsonProperty("total_drugs_speed")>
        Public Property TotalDrugsSpeed As Long
        <JsonProperty("total_drugs_pcp")>
        Public Property TotalDrugsPcp As Long
        <JsonProperty("total_drugs_xanax")>
        Public Property TotalDrugsXanax As Long
        <JsonProperty("total_drugs_vicodin")>
        Public Property TotalDrugsVicodin As Long
        <JsonProperty("total_merits_bought")>
        Public Property TotalMeritsBought As Long
        <JsonProperty("total_refills_bought")>
        Public Property TotalRefillsBought As Long
        <JsonProperty("total_company_trains")>
        Public Property TotalCompanyTrains As Long
        <JsonProperty("total_statenhancers_used")>
        Public Property TotalStatenhancersUsed As Long
    End Class
End Namespace
