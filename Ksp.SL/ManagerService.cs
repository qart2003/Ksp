using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ksp.SL
{
  public class ManagerService
  {
    private QueueService _queueService;
    private SearchAlgorythmService _searchAlgorythmService;

    public QueueService QueueService {  get { return _queueService ?? new QueueService(); } }
    public SearchAlgorythmService SearchAlgorythmService { get { return _searchAlgorythmService ?? new SearchAlgorythmService(); } }
    public ManagerService()
    {

    }
  }
}
