using GHNamespace1;
using GHNamespace2;

namespace GHNamespaceM
{
    public abstract class Class175 : INterface5
    {
        public abstract void vmethod_0(Class13 class130);

        public abstract void vmethod_1(Class13 class130, Class13 class131);

        public void imethod_0(Class13[] class130)
        {
            if (class130.Length == 1)
            {
                vmethod_0(class130[0]);
                return;
            }
            for (int i = 1; i < class130.Length; i++)
            {
                vmethod_1(class130[0], class130[i]);
            }
        }
    }
}