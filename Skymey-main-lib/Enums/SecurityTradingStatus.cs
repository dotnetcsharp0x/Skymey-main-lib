using Google.Protobuf.Reflection;

public enum SecurityTradingStatus
{
    //
    // Сводка:
    //     Торговый статус не определён
    [OriginalName("SECURITY_TRADING_STATUS_UNSPECIFIED")]
    Unspecified,
    //
    // Сводка:
    //     Недоступен для торгов
    [OriginalName("SECURITY_TRADING_STATUS_NOT_AVAILABLE_FOR_TRADING")]
    NotAvailableForTrading,
    //
    // Сводка:
    //     Период открытия торгов
    [OriginalName("SECURITY_TRADING_STATUS_OPENING_PERIOD")]
    OpeningPeriod,
    //
    // Сводка:
    //     Период закрытия торгов
    [OriginalName("SECURITY_TRADING_STATUS_CLOSING_PERIOD")]
    ClosingPeriod,
    //
    // Сводка:
    //     Перерыв в торговле
    [OriginalName("SECURITY_TRADING_STATUS_BREAK_IN_TRADING")]
    BreakInTrading,
    //
    // Сводка:
    //     Нормальная торговля
    [OriginalName("SECURITY_TRADING_STATUS_NORMAL_TRADING")]
    NormalTrading,
    //
    // Сводка:
    //     Аукцион закрытия
    [OriginalName("SECURITY_TRADING_STATUS_CLOSING_AUCTION")]
    ClosingAuction,
    //
    // Сводка:
    //     Аукцион крупных пакетов
    [OriginalName("SECURITY_TRADING_STATUS_DARK_POOL_AUCTION")]
    DarkPoolAuction,
    //
    // Сводка:
    //     Дискретный аукцион
    [OriginalName("SECURITY_TRADING_STATUS_DISCRETE_AUCTION")]
    DiscreteAuction,
    //
    // Сводка:
    //     Аукцион открытия
    [OriginalName("SECURITY_TRADING_STATUS_OPENING_AUCTION_PERIOD")]
    OpeningAuctionPeriod,
    //
    // Сводка:
    //     Период торгов по цене аукциона закрытия
    [OriginalName("SECURITY_TRADING_STATUS_TRADING_AT_CLOSING_AUCTION_PRICE")]
    TradingAtClosingAuctionPrice,
    //
    // Сводка:
    //     Сессия назначена
    [OriginalName("SECURITY_TRADING_STATUS_SESSION_ASSIGNED")]
    SessionAssigned,
    //
    // Сводка:
    //     Сессия закрыта
    [OriginalName("SECURITY_TRADING_STATUS_SESSION_CLOSE")]
    SessionClose,
    //
    // Сводка:
    //     Сессия открыта
    [OriginalName("SECURITY_TRADING_STATUS_SESSION_OPEN")]
    SessionOpen,
    //
    // Сводка:
    //     Доступна торговля в режиме внутренней ликвидности брокера
    [OriginalName("SECURITY_TRADING_STATUS_DEALER_NORMAL_TRADING")]
    DealerNormalTrading,
    //
    // Сводка:
    //     Перерыв торговли в режиме внутренней ликвидности брокера
    [OriginalName("SECURITY_TRADING_STATUS_DEALER_BREAK_IN_TRADING")]
    DealerBreakInTrading,
    //
    // Сводка:
    //     Недоступна торговля в режиме внутренней ликвидности брокера
    [OriginalName("SECURITY_TRADING_STATUS_DEALER_NOT_AVAILABLE_FOR_TRADING")]
    DealerNotAvailableForTrading
}