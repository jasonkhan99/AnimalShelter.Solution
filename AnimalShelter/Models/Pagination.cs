namespace AnimalShelter.Models
{
  public class Pagination
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public Pagination()
    {
      this.PageNumber = 1;
      this.PageSize = 20;
    }

    public Pagination(int pageNumber, int pageSize)
    {
      this.PageNumber = pageNumber;
      this.PageSize = pageSize;
    }
  }
}