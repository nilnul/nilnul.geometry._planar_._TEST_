using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.morph_.cramp_.eg_
{
	///加拿大数学家莱奥·莫泽（Leo Moser）于1966年首次正式提出，其约束条件包括：“沙发”可以是任意形状的刚性（两端受压不会形变）二维几何体；在单位宽度的直角走廊内完成转向 ；“沙发”不可抬离地面，仅允许平面滑动（平移）与旋转（因此问题被完全限制在二维平面内）。
	///
	/// 在知名数学论坛MathOverflow“极易理解的非著名长期未解问题”榜单上，移动沙发问题目前高居第二。
	/// 
	/// 显然，边长为1的正方形是首个符合条件的解——它在通过直角时无需任何旋转。但如果将正方形略微拉长为矩形，你会发现它在转角处会因无法旋转而彻底卡死。
	/// 
	/// 以直径为2的半圆形为例，其直线边在转角时虽会凸出原走廊，但弧形边刚好为转向预留了足够的空间。为了找到能在拐角处转向的最大沙发,我们可以做简单的计算。根据几何公式，半圆沙发的面积是π/2（约1.57），相比正方形面积为1，提升了约57%。
	/// 
	/// 1968年，英国数学家约翰·哈默斯利（John Hammersley）取得了里程碑式的突破：通过将半圆拉长并从中切掉一块，可以设计出面积更大的、形似老式电话听筒的“哈默斯利沙发”。这种设计证明，混合旋转平移的运动方式的确能有效提升空间利用率。
	/// 
	/// 直到1992年，美国罗格斯大学的数学家约瑟夫·L.杰弗（Joseph L. Gerver）创作出一项神奇的数学工艺品——这是移动沙发问题迄今已知面积最大的沙发。
	/// 
	/// 资料来源：“On Moving a Sofa Around a Corner,” by Joseph L. Gerver, in Geometriae Dedicata, Vol. 42, No. 3; June 1992
	/// 
	/// 精密拼接18段特殊的曲线得到了形似沙发的复杂结构。如果仔细观察，你可能会发现一些精妙的细节，比如圆形切口底部的斜角等设计
	/// 
	/// 杰弗沙发的面积约为2.2195，仅比哈默斯利方案提升了0.012。
	/// 
	/// 
	/// 2411: 韩国延世大学的博士后研究员白眞言（Jineon Baek）在线上发布论文，宣称已解决了移动沙发问题;
	/// 
	/// 他整合了所有创新思路并严格证明：杰弗沙发就是移动沙发问题中面积最大的沙发。
	/// 
	/// 
	/// https://www.scientificamerican.com/article/mathematicians-solve-infamous-moving-sofa-problem/
	/// 
	/// <summary>
	/// Moving Sofa Problem
	/// </summary>
	/// 
	internal class ISofaAroundCorner
	{
	}
}
