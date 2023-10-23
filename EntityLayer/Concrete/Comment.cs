using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete;

public class Comment
{
    [Key]
  public string CommentId { get; set; }
  public string CommentUser { get; set; }
  public DateTime CommentTime { get; set; }
  public string CommentContent { get; set; }
  public string CommentState {  get; set; }
  public int ProductId {  get; set; }
  public virtual Product Products { get; set; }
}
