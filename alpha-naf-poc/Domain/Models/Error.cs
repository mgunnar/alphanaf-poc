using alpha_naf_poc.Domain.Constants;

namespace alpha_naf_poc.Domain.Models;

public class Error
{
    public ErrorCodes Code { get; set; }
    public string Message { get; set; }
}
