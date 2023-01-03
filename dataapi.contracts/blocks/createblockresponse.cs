namespace dataapi.Contracts.Createblock;

public record CreateblockResponse(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);
