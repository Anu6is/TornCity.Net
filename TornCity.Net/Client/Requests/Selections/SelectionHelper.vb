Option Strict On
Option Infer On

Imports System.Runtime.CompilerServices
Imports TornCity.Net.Models

Public Module SelectionHelper
    <Extension>
    Friend Function ToTornResource(selector As [Enum]) As Type
        Dim fieldInfo = selector.GetType.GetField(selector.ToString)
        Dim attribute = DirectCast(fieldInfo.GetCustomAttributes(GetType(TornResourceAttribute), False).FirstOrDefault, TornResourceAttribute)

        Return attribute.Type
    End Function

    Public Enum CompanySelection
        <TornResource(GetType(Company.Profile))>
        profile
        <TornResource(GetType(Company.Detailed))>
        detailed
        <TornResource(GetType(Company.Employees))>
        employees
        <TornResource(GetType(Company.News))>
        news
        <TornResource(GetType(Company.NewsFull))>
        newsfull
        <TornResource(GetType(Company.Stock))>
        stock
    End Enum

    Public Enum FactionSelection
        <TornResource(GetType(Faction.Basic))>
        basic
        <TornResource(GetType(Faction.Armor))>
        armor
        <TornResource(GetType(Faction.ArmoryNews))>
        armorynews
        <TornResource(GetType(Faction.ArmoryNewsFull))>
        armorynewsfull
        <TornResource(GetType(Faction.AttackNews))>
        attacknews
        <TornResource(GetType(Faction.AttackNewsFull))>
        attacknewsfull
        <TornResource(GetType(Faction.Attacks))>
        attacks
        <TornResource(GetType(Faction.AttacksFull))>
        attacksfull
        <TornResource(GetType(Faction.Boosters))>
        boosters
        <TornResource(GetType(Faction.Cesium))>
        cesium
        <TornResource(GetType(Faction.Chain))>
        chain
        <TornResource(GetType(Faction.Chains))>
        chains
        <TornResource(GetType(Faction.CrimeNews))>
        crimenews
        <TornResource(GetType(Faction.CrimeNewsFull))>
        crimenewsfull
        <TornResource(GetType(Faction.Crimes))>
        crimes
        <TornResource(GetType(Faction.Currency))>
        currency
        <TornResource(GetType(Faction.Donations))>
        donations
        <TornResource(GetType(Faction.Drugs))>
        drugs
        <TornResource(GetType(Faction.FundsNews))>
        fundsnews
        <TornResource(GetType(Faction.FundsNewsFull))>
        fundsnewsfull
        <TornResource(GetType(Faction.MainNews))>
        mainnews
        <TornResource(GetType(Faction.MainNewsFull))>
        mainnewsfull
        <TornResource(GetType(Faction.Medical))>
        medical
        <TornResource(GetType(Faction.MembershipNews))>
        membershipnews
        <TornResource(GetType(Faction.MembershipNewsFull))>
        membershipnewsfull
        <TornResource(GetType(Faction.Revives))>
        revives
        <TornResource(GetType(Faction.RevivesFull))>
        revivesfull
        <TornResource(GetType(Faction.Stats))>
        stats
        <TornResource(GetType(Faction.Temporary))>
        temporary
        <TornResource(GetType(Faction.Upgrades))>
        upgrades
        <TornResource(GetType(Faction.Weapons))>
        weapons
    End Enum

    Public Enum ItemMarketSelection
        <TornResource(GetType(Market.Bazaar))>
        bazaar
        <TornResource(GetType(Market.ItemMarket))>
        itemmarket
        <TornResource(GetType(Market.PointsMarket))>
        pointsmarket
    End Enum

    Public Enum PropertySelection
        <TornResource(GetType([Property].Property))>
        [property]
    End Enum

    Public Enum TornSelection
        <TornResource(GetType(Torn.Stats))>
        stats
        <TornResource(GetType(Torn.Companies))>
        companies
        <TornResource(GetType(Torn.Education))>
        education
        <TornResource(GetType(Torn.FactionTree))>
        factiontree
        <TornResource(GetType(Torn.Gyms))>
        gyms
        <TornResource(GetType(Torn.Honors))>
        honors
        <TornResource(GetType(Torn.Items))>
        items
        <TornResource(GetType(Torn.Medals))>
        medals
        <TornResource(GetType(Torn.OrganisedCrimes))>
        organisedcrimes
        <TornResource(GetType(Torn.Properties))>
        properties
        <TornResource(GetType(Torn.Stocks))>
        stocks
    End Enum

    Public Enum UserSelection
        <TornResource(GetType(User.Profile))>
        profile
        <TornResource(GetType(User.Attacks))>
        attacks
        <TornResource(GetType(User.AttacksFull))>
        attacksfull
        <TornResource(GetType(User.Bars))>
        bars
        <TornResource(GetType(User.Basic))>
        basic
        <TornResource(GetType(User.BattleStats))>
        battlestats
        <TornResource(GetType(User.Bazaar))>
        bazaar
        <TornResource(GetType(User.Cooldowns))>
        cooldowns
        <TornResource(GetType(User.Crimes))>
        crimes
        <TornResource(GetType(User.Discord))>
        discord
        <TornResource(GetType(User.Display))>
        display
        <TornResource(GetType(User.Education))>
        education
        <TornResource(GetType(User.Events))>
        events
        <TornResource(GetType(User.Gym))>
        gym
        <TornResource(GetType(User.Hof))>
        hof
        <TornResource(GetType(User.Honors))>
        honors
        <TornResource(GetType(User.Icons))>
        icons
        <TornResource(GetType(User.Inventory))>
        inventory
        <TornResource(GetType(User.JobPoints))>
        jobpoints
        <TornResource(GetType(User.Medals))>
        medals
        <TornResource(GetType(User.Merits))>
        merits
        <TornResource(GetType(User.Messages))>
        messages
        <TornResource(GetType(User.Money))>
        money
        <TornResource(GetType(User.Networth))>
        networth
        <TornResource(GetType(User.Notifications))>
        notifications
        <TornResource(GetType(User.Perks))>
        perks
        <TornResource(GetType(User.PersonalStats))>
        personalstats
        <TornResource(GetType(User.Properties))>
        properties
        <TornResource(GetType(User.Refills))>
        refills
        <TornResource(GetType(User.Revives))>
        revives
        <TornResource(GetType(User.RevivesFull))>
        revivesfull
        <TornResource(GetType(User.Stocks))>
        stocks
        <TornResource(GetType(User.Travel))>
        travel
        <TornResource(GetType(User.WorkStats))>
        workstats
    End Enum
End Module
