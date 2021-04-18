namespace AlbanianXrm.SolutionPackager.Models
{
    public class ProgressData<T>
    {
        public int ProgressPercentage { get; set; }
        public T UserState { get; set; }
    }
}
