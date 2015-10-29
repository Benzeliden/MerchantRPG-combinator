﻿using System;

namespace MerchantRPG.Simulation
{
	public static class BattleTurnsCache
	{
		public static double[,] Turns = {
			{ 2, 1.99, 1.98, 1.97, 1.96, 1.95, 1.94, 1.93, 1.92, 1.91, 1.9, 1.89, 1.88, 1.87, 1.86, 1.85, 1.84, 1.83, 1.82, 1.81, 1.8, 1.79, 1.78, 1.77, 1.76, 1.75, 1.74, 1.73, 1.72, 1.71, 1.7, 1.69, 1.68, 1.67, 1.66, 1.65, 1.64, 1.63, 1.62, 1.61, 1.6, 1.59, 1.58, 1.57, 1.56, 1.55, 1.54, 1.53, 1.52, 1.51, 1.5, 1.49, 1.48, 1.47, 1.46, 1.45, 1.44, 1.43, 1.42, 1.41, 1.4, 1.39, 1.38, 1.37, 1.36, 1.35, 1.34, 1.33, 1.32, 1.31, 1.3, 1.29, 1.28, 1.27, 1.26, 1.25, 1.24, 1.23, 1.22, 1.21, 1.2, 1.19, 1.18, 1.17, 1.16, 1.15, 1.14, 1.13, 1.12, 1.11, 1.1, 1.09, 1.08, 1.07, 1.06, 1.05, 1.04, 1.03, 1.02, 1.01, 1, },
			{ 3, 2.9801, 2.9604, 2.9409, 2.9216, 2.9025, 2.8836, 2.8649, 2.8464, 2.8281, 2.81, 2.7921, 2.7744, 2.7569, 2.7396, 2.7225, 2.7056, 2.6889, 2.6724, 2.6561, 2.64, 2.6241, 2.6084, 2.5929, 2.5776, 2.5625, 2.5476, 2.5329, 2.5184, 2.5041, 2.49, 2.4761, 2.4624, 2.4489, 2.4356, 2.4225, 2.4096, 2.3969, 2.3844, 2.3721, 2.36, 2.3481, 2.3364, 2.3249, 2.3136, 2.3025, 2.2916, 2.2809, 2.2704, 2.2601, 2.25, 2.2401, 2.2304, 2.2209, 2.2116, 2.2025, 2.1936, 2.1849, 2.1764, 2.1681, 2.16, 2.1521, 2.1444, 2.1369, 2.1296, 2.1225, 2.1156, 2.1089, 2.1024, 2.0961, 2.09, 2.0841, 2.0784, 2.0729, 2.0676, 2.0625, 2.0576, 2.0529, 2.0484, 2.0441, 2.04, 2.0361, 2.0324, 2.0289, 2.0256, 2.0225, 2.0196, 2.0169, 2.0144, 2.0121, 2.01, 2.0081, 2.0064, 2.0049, 2.0036, 2.0025, 2.0016, 2.0009, 2.0004, 2.0001, 2, },
			{ 4, 3.970199, 3.940792, 3.911773, 3.883136, 3.854875, 3.826984, 3.799457, 3.772288, 3.745471, 3.719, 3.692869, 3.667072, 3.641603, 3.616456, 3.591625, 3.567104, 3.542887, 3.518968, 3.495341, 3.472, 3.448939, 3.426152, 3.403633, 3.381376, 3.359375, 3.337624, 3.316117, 3.294848, 3.273811, 3.253, 3.232409, 3.212032, 3.191863, 3.171896, 3.152125, 3.132544, 3.113147, 3.093928, 3.074881, 3.056, 3.037279, 3.018712, 3.000293, 2.982016, 2.963875, 2.945864, 2.927977, 2.910208, 2.892551, 2.875, 2.857549, 2.840192, 2.822923, 2.805736, 2.788625, 2.771584, 2.754607, 2.737688, 2.720821, 2.704, 2.687219, 2.670472, 2.653753, 2.637056, 2.620375, 2.603704, 2.587037, 2.570368, 2.553691, 2.537, 2.520289, 2.503552, 2.486783, 2.469976, 2.453125, 2.436224, 2.419267, 2.402248, 2.385161, 2.368, 2.350759, 2.333432, 2.316013, 2.298496, 2.280875, 2.263144, 2.245297, 2.227328, 2.209231, 2.191, 2.172629, 2.154112, 2.135443, 2.116616, 2.097625, 2.078464, 2.059127, 2.039608, 2.019901, 2, },
			{ 5, 4.96029801, 4.92118416, 4.88264681, 4.84467456, 4.80725625, 4.77038096, 4.73403801, 4.69821696, 4.66290761, 4.6281, 4.59378441, 4.55995136, 4.52659161, 4.49369616, 4.46125625, 4.42926336, 4.39770921, 4.36658576, 4.33588521, 4.3056, 4.27572281, 4.24624656, 4.21716441, 4.18846976, 4.16015625, 4.13221776, 4.10464841, 4.07744256, 4.05059481, 4.0241, 3.99795321, 3.97214976, 3.94668521, 3.92155536, 3.89675625, 3.87228416, 3.84813561, 3.82430736, 3.80079641, 3.7776, 3.75471561, 3.73214096, 3.70987401, 3.68791296, 3.66625625, 3.64490256, 3.62385081, 3.60310016, 3.58265001, 3.5625, 3.54265001, 3.52310016, 3.50385081, 3.48490256, 3.46625625, 3.44791296, 3.42987401, 3.41214096, 3.39471561, 3.3776, 3.36079641, 3.34430736, 3.32813561, 3.31228416, 3.29675625, 3.28155536, 3.26668521, 3.25214976, 3.23795321, 3.2241, 3.21059481, 3.19744256, 3.18464841, 3.17221776, 3.16015625, 3.14846976, 3.13716441, 3.12624656, 3.11572281, 3.1056, 3.09588521, 3.08658576, 3.07770921, 3.06926336, 3.06125625, 3.05369616, 3.04659161, 3.03995136, 3.03378441, 3.0281, 3.02290761, 3.01821696, 3.01403801, 3.01038096, 3.00725625, 3.00467456, 3.00264681, 3.00118416, 3.00029801, 3, },
			{ 6, 5.9503970199, 5.9015763168, 5.8535205957, 5.8062130176, 5.7596371875, 5.7137771424, 5.6686173393, 5.6241426432, 5.5803383151, 5.53719, 5.4946837149, 5.4528058368, 5.4115430907, 5.3708825376, 5.3308115625, 5.2913178624, 5.2523894343, 5.2140145632, 5.1761818101, 5.13888, 5.1020982099, 5.0658257568, 5.0300521857, 4.9947672576, 4.9599609375, 4.9256233824, 4.8917449293, 4.8583160832, 4.8253275051, 4.79277, 4.7606345049, 4.7289120768, 4.6975938807, 4.6666711776, 4.6361353125, 4.6059777024, 4.5761898243, 4.5467632032, 4.5176894001, 4.48896, 4.4605665999, 4.4325007968, 4.4047541757, 4.3773182976, 4.3501846875, 4.3233448224, 4.2967901193, 4.2705119232, 4.2445014951, 4.21875, 4.1932484949, 4.1679879168, 4.1429590707, 4.1181526176, 4.0935590625, 4.0691687424, 4.0449718143, 4.0209582432, 3.9971177901, 3.97344, 3.9499141899, 3.9265294368, 3.9032745657, 3.8801381376, 3.8571084375, 3.8341734624, 3.8113209093, 3.7885381632, 3.7658122851, 3.74313, 3.7204776849, 3.6978413568, 3.6752066607, 3.6525588576, 3.6298828125, 3.6071629824, 3.5843834043, 3.5615276832, 3.5385789801, 3.51552, 3.4923329799, 3.4689996768, 3.4455013557, 3.4218187776, 3.3979321875, 3.3738213024, 3.3494652993, 3.3248428032, 3.2999318751, 3.27471, 3.2491540749, 3.2232403968, 3.1969446507, 3.1702418976, 3.1431065625, 3.1155124224, 3.0874325943, 3.0588395232, 3.0297049701, 3, },
			{ 7, 6.94049602980101, 6.881968473664, 6.824394382129, 6.767751479296, 6.712018140625, 6.65717337145599, 6.603196786249, 6.55006858854401, 6.497769551641, 6.446281, 6.39558479136101, 6.345663299584, 6.29649939820899, 6.248076444736, 6.200378265625, 6.15338914201599, 6.107093796169, 6.061477378624, 6.016525456081, 5.972224, 5.928559375921, 5.885518333504, 5.843087997289, 5.80125585817599, 5.760009765625, 5.719337920576, 5.679228869089, 5.639671496704, 5.600655023521, 5.562169, 5.524203303481, 5.486748135424, 5.449794019369, 5.413331799616, 5.377352640625, 5.341848027136, 5.306809765009, 5.272229982784, 5.238101133961, 5.204416, 5.171167694041, 5.138349665344, 5.105955704449, 5.073979949056, 5.042416890625, 5.011261381696, 4.980508643929, 4.950154276864, 4.920194267401, 4.890625, 4.861443267601, 4.832646283264, 4.804231692529, 4.776197586496, 4.748542515625, 4.721265504256, 4.694366065849, 4.667844218944, 4.641700503841, 4.615936, 4.590552344161, 4.565551749184, 4.540937023609, 4.516711591936, 4.492879515625, 4.469445514816, 4.446414990769, 4.423794049024, 4.401589523281, 4.379809, 4.358460843721, 4.337554223104, 4.317099137689, 4.297106445376, 4.277587890625, 4.258556133376, 4.240024778689, 4.222008407104, 4.204522605721, 4.187584, 4.171210286281, 4.155420265024, 4.140233874769, 4.125672226816, 4.111757640625, 4.098513679936, 4.085965189609, 4.074138333184, 4.063060631161, 4.052761, 4.043269791841, 4.034618834944, 4.026841474849, 4.019972616256, 4.014048765625, 4.009108074496, 4.005190383529, 4.002337267264, 4.000592079601, 4, },
			{ 8, 7.930595039702, 7.86236063052671, 7.79526816853612, 7.72928994082817, 7.66439909296876, 7.60056959771263, 7.53777622496257, 7.47599451291649, 7.41520074035232, 7.3553719, 7.2964856729503, 7.23852040404993, 7.18145507823282, 7.12526929773697, 7.06994326015625, 7.01545773727743, 6.96179405465126, 6.90893407184769, 6.85686016334461, 6.80555520000001, 6.75500253105659, 6.70518596662912, 6.65608976062352, 6.60769859403775, 6.55999755859375, 6.51297214065025, 6.46660820534597, 6.42089198092289, 6.37581004317892, 6.33134930000001, 6.28749697592089, 6.24424059666432, 6.20156797360823, 6.15946718813055, 6.11792657578125, 6.07693471023104, 6.03648038694667, 5.99655260654208, 5.95714055775522, 5.9182336, 5.87982124544319, 5.84189314055552, 5.80443904708693, 5.76744882241536, 5.73091239921876, 5.69481976441984, 5.65916093735337, 5.62392594710529, 5.58910480897351, 5.5546875, 5.52066393352349, 5.48702393270272, 5.45375720295963, 5.42085330329216, 5.38830161640625, 5.35609131761664, 5.32421134246607, 5.29265035301249, 5.26139670273381, 5.2304384, 5.19976307006179, 5.16935791550593, 5.13920967512633, 5.10930458116096, 5.07962831484375, 5.05016596022144, 5.02090195618477, 4.99182004666368, 4.96290322893611, 4.9341337, 4.90549280095809, 4.87696095936512, 4.84851762948703, 4.82014123042176, 4.79180908203125, 4.76349733863424, 4.73518092040947, 4.70683344245888, 4.67842714148041, 4.6499328, 4.62131966811239, 4.59255538268032, 4.56360588394173, 4.53443532947456, 4.50500600546875, 4.47527823525504, 4.44521028504017, 4.41475826679808, 4.38387603826671, 4.3525151, 4.32062448942469, 4.28815067185152, 4.25503742839043, 4.22122574071936, 4.18665367265625, 4.15125624848384, 4.11496532797687, 4.07770947808128, 4.03941384119501, 4, },
			{ 9, 8.92069404960299, 8.84275278738946, 8.76614195494391, 8.69082840236686, 8.61678004535153, 8.54396582413725, 8.47235566425262, 8.40192043896668, 8.33263193336829, 8.26446281, 8.19738657597549, 8.13137755151401, 8.06641083982973, 8.00246229831685, 7.93950851097657, 7.87752676203559, 7.81649501070928, 7.75639186706743, 7.69719656896453, 7.63888896000001, 7.58144946847812, 7.52485908734159, 7.46909935505658, 7.41415233743094, 7.36000061035156, 7.30662724343096, 7.25401578455659, 7.2021502453416, 7.15101508747812, 7.10059521000002, 7.05087593746453, 7.00184300906742, 6.95348256870928, 6.90578115603561, 6.85872569847657, 6.81230350431683, 6.76650225682973, 6.72131000951402, 6.67671518247548, 6.63270655999999, 6.58927328936828, 6.54640488096668, 6.50409120975263, 6.46232251813725, 6.42108942035157, 6.38038290836687, 6.34019435944392, 6.30051554538947, 6.26133864360298, 6.22265625, 6.18446139390302, 6.14674755499459, 6.1095086824314, 6.07273921622223, 6.03643411097657, 6.00058886213469, 5.96519953479435, 5.93026279525277, 5.89577594538705, 5.86173696, 5.82814452726231, 5.79499809238634, 5.76229790467041, 5.73004506805698, 5.69824159535156, 5.66689046625385, 5.6359956893562, 5.6055623682687, 5.57559677203408, 5.54610641, 5.51710011131976, 5.48858810925711, 5.46058213047447, 5.4330954894879, 5.40614318847656, 5.37974202263797, 5.3539106912847, 5.32866991488207, 5.30404255823048, 5.28005376, 5.25673106882896, 5.23410458620214, 5.21220711632836, 5.19107432324137, 5.17074489535156, 5.15126071768067, 5.13266705201505, 5.11501272521769, 5.09835032594263, 5.08273641, 5.06823171462353, 5.0549013818966, 5.0428151915969, 5.0320478037238, 5.02267901097656, 5.01479400145551, 5.00848363186243, 5.00384471148034, 5.00098029721694, 5, },
			{ 10, 9.91079305950397, 9.82314494425222, 9.73701574135163, 9.65236686390529, 9.56916099773233, 9.48736205055179, 9.40693510350235, 9.32784636488268, 9.25006312599685, 9.17355371900001, 9.09828747664274, 9.02423469381832, 8.95136659082214, 8.87965527823568, 8.80907372335352, 8.73959571807429, 8.6711958481794, 8.60384946392788, 8.53753265189676, 8.47222220800001, 8.40789561161962, 8.34453100078486, 8.28210714833697, 8.22060343901656, 8.15999984741211, 8.10027691670799, 8.04141573816974, 7.98339793130435, 7.92620562463135, 7.86982143700003, 7.814228459386, 7.75941023709841, 7.70535075232592, 7.65203440694789, 7.59944600553322, 7.54757073844596, 7.49639416497299, 7.44590219638468, 7.3960810788346, 7.34691737599999, 7.29839795135898, 7.250509949994, 7.20324077980638, 7.15657809201962, 7.11050976084181, 7.06502386215122, 7.02010865106136, 6.97575253821306, 6.93194406463454, 6.888671875, 6.84592468910946, 6.80369127140282, 6.76196039831136, 6.72072082323998, 6.6799612389629, 6.63967023720458, 6.59983626516724, 6.56044757875341, 6.52149219222164, 6.482957824, 6.44483183837, 6.40710118272048, 6.36975232005764, 6.33277115644353, 6.29614296302149, 6.25985229227246, 6.22388288813134, 6.18821758957728, 6.15283822729647, 6.11772551300001, 6.08285892096297, 6.04821656133488, 6.01377504475365, 5.97950933777896, 5.94539260864258, 5.91139606279513, 5.87748876771077, 5.84363746639198, 5.80980637899792, 5.775956992, 5.74204783424854, 5.70803423931425, 5.67386809344746, 5.63949756847725, 5.60486683895117, 5.56991578279463, 5.5345796647469, 5.49878880180844, 5.46246820991106, 5.42553723100001, 5.38790913969259, 5.34949072865513, 5.31018187181488, 5.26987506449962, 5.22845493957227, 5.1857977586027, 5.14177087709343, 5.09623218274926, 5.04902950575523, 5, },
			{ 11, 10.900892069405, 10.803537101115, 10.7078895277594, 10.6139053254437, 10.5215419501132, 10.4307582769669, 10.3415145427549, 10.2537722908095, 10.1674943186603, 10.0826446281, 9.99918837756938, 9.91709183674184, 9.83632234319316, 9.75684826104705, 9.678638941497, 9.6016646851081, 9.52589670580947, 9.45130709649302, 9.37786879613963, 9.30555555840001, 9.23434192155994, 9.16420317982734, 9.09511535588247, 9.02705517463597, 8.96000003814697, 8.89392800165593, 8.82881775069423, 8.76464857923479, 8.70140036885689, 8.63905356890002, 8.57758917759031, 8.5169887241285, 8.45723425173242, 8.39830830163773, 8.34019389806338, 8.28287453415947, 8.22633415895999, 8.17055716537381, 8.11552837925455, 8.06123304959999, 8.00765683994278, 7.95478582100254, 7.90260646468326, 7.8511056395114, 7.80027060762121, 7.75008902341041, 7.70054893400115, 7.65163878165773, 7.60334740832908, 7.5556640625, 7.50857840855417, 7.46208053887056, 7.41616098889497, 7.37081075545037, 7.32602131857043, 7.28178466716544, 7.23809332885469, 7.19494040432303, 7.15231960658922, 7.1102253056, 7.06865257859432, 7.02759726671331, 6.98705603836369, 6.94702645987615, 6.90750707403604, 6.86849748710019, 6.82999846495198, 6.79201203908744, 6.75454162316542, 6.71759214090002, 6.68117016611629, 6.64528407583889, 6.60994421732985, 6.57516309004359, 6.54095554351807, 6.5073389922757, 6.4743336488627, 6.44196277621425, 6.41025296059164, 6.3792344064, 6.34894125425869, 6.31941192376232, 6.29068948243861, 6.26282204247911, 6.2358631868915, 6.20987242679662, 6.18491569167019, 6.16106585440858, 6.13840329317915, 6.11701649210001, 6.09700268287976, 6.07846852963728, 6.06153085921215, 6.04631743937035, 6.03296780740634, 6.02163415174139, 6.01248224921936, 6.00569246090571, 6.00146078930232, 6, },
			{ 12, 11.8909910793059, 11.7839292579777, 11.6787633141672, 11.5754437869822, 11.4739229024942, 11.374154503382, 11.2760939820072, 11.1796982167353, 11.0849255113206, 10.9917355371901, 10.9000892784675, 10.8099489795911, 10.721278095385, 10.6340412434534, 10.5482041587756, 10.4637336503826, 10.3805975600124, 10.2987647226313, 10.2182049287335, 10.13888888832, 10.0607881964725, 9.98387530043796, 9.908123468147, 9.83350675808728, 9.75999999046326, 9.68757871956945, 9.61621920731266, 9.54589839781425, 9.47659389303145, 9.40828392932999, 9.34094735494693, 9.27456360827891, 9.20911269692827, 9.14457517744322, 9.08093213567781, 9.01816516770259, 8.95625636118482, 8.89518827715794, 8.83494393209078, 8.77550678015998, 8.7168606956234, 8.65898995517894, 8.60187922018618, 8.54551351861506, 8.48987822657051, 8.43495904923118, 8.38074200101941, 8.3272133848043, 8.27435976991874, 8.22216796875, 8.17062501163737, 8.11971811978733, 8.06943467588562, 8.01976219205676, 7.97068827478629, 7.92220058638739, 7.87428680255284, 7.82693456549265, 7.78013143211234, 7.73386481663998, 7.68812192705749, 7.64288969463775, 7.59815469583086, 7.5539030656793, 7.51012040187656, 7.46679165851391, 7.42390102848212, 7.38143181342053, 7.33936628001583, 7.29768550137002, 7.25636918205745, 7.21539546539601, 7.17474072134922, 7.13437931336779, 7.09428334236145, 7.05442236587046, 7.01476309037572, 6.97526903455288, 6.9359001611326, 6.89661247488, 6.85735758405046, 6.81808222251491, 6.77872772957594, 6.73922948431754, 6.69951629114222, 6.65950971295491, 6.61912334824692, 6.57826204812045, 6.53682106907055, 6.49468515711001, 6.45172755857945, 6.40780895273369, 6.36277630093268, 6.31646160699187, 6.26868058296396, 6.21923121432825, 6.16789221825721, 6.11442138831238, 6.05855381859069, 6, },
			{ 13, 12.881090089207, 12.7643214148404, 12.6496371005752, 12.5369822485207, 12.4263038548753, 12.3175507297972, 12.2106734212595, 12.1056241426613, 12.0023567039812, 11.9008264462812, 11.8009901793688, 11.7028061224493, 11.6062338475999, 11.5112342259164, 11.4177693761838, 11.3258026159387, 11.2352984147981, 11.1462223499264, 11.0585410635408, 10.972222222336, 10.8872344787409, 10.8035474339036, 10.7211316023262, 10.639958378059, 10.5600000023842, 10.4812295329119, 10.4036208140258, 10.327148448612, 10.2517877710208, 10.177514821201, 10.1043063199664, 10.0321396453508, 9.9609928100137, 9.89084443966938, 9.82167375251264, 9.75346053962703, 9.68618514636163, 9.61982845467999, 9.55437186648463, 9.48979728793593, 9.4260871147944, 9.36322421882481, 9.30119193531989, 9.2399740518094, 9.17955479804329, 9.1199188373536, 9.06105125952086, 9.00293757529396, 8.94556371273984, 8.888916015625, 8.83298124406491, 8.77774657771063, 8.72319962178053, 8.66932841628933, 8.61612144886754, 8.56356767162315, 8.51165652254493, 8.4603779520143, 8.4097224550537, 8.35968111001596, 8.31024562449496, 8.26140838932457, 8.21316254162653, 8.16550203796533, 8.11842173878021, 8.07191750538087, 8.0259863109169, 7.98062636687403, 7.93583726678902, 7.89162014904104, 7.84797788073923, 7.80491526491487, 7.7624392734151, 7.72055930810789, 7.67928749322891, 7.63863900193841, 7.5986324204107, 7.55929015304875, 7.52063887270526, 7.48271002009602, 7.44554035691911, 7.40917257753782, 7.37365598445194, 7.33904723317324, 7.30541115252908, 7.27282164685879, 7.24136268702516, 7.21112939765399, 7.18222924852722, 7.15478335860103, 7.12892792169274, 7.10481576348499, 7.08261804013259, 7.06252608942764, 7.04475344618421, 7.02953803424489, 7.01714454829049, 7.00786703945386, 7.00203171959519, 7, },
			{ 14, 13.8711890991079, 13.7447135717031, 13.6205108869832, 13.4985207100592, 13.3786848072563, 13.2609469562126, 13.1452528605116, 13.0315500685874, 12.9197878966415, 12.8099173553722, 12.7018910802697, 12.5956632653064, 12.4911895998119, 12.3884272083715, 12.2873345935726, 12.1878715814497, 12.0899992694848, 11.9936799770131, 11.8988771979276, 11.8055555555328, 11.7136807594645, 11.6232195645413, 11.534139731465, 11.4464099892657, 11.359999999404, 11.2748803214429, 11.1910223802132, 11.1083984343887, 11.0269815464038, 10.9467455536398, 10.8676650408103, 10.7897153134879, 10.7128723726956, 10.6371128905125, 10.5624141866203, 10.4887542057342, 10.4161114958461, 10.3444651872216, 10.273794972071, 10.2040810848254, 10.1353042829344, 10.0674458280935, 10.0004874678123, 9.9344114172037, 9.86920034088045, 9.8048373348173, 9.74130590802527, 9.67858996385892, 9.61667378075761, 9.5555419921875, 9.49517956552687, 9.43557177959054, 9.37670420045628, 9.31856265520373, 9.26113320312281, 9.20440210389108, 9.14835578214947, 9.09298078783178, 9.0382637515183, 8.98419133399037, 8.9307501690581, 8.87792679861869, 8.82570759877528, 8.7740786957023, 8.72302586979281, 8.67253444644868, 8.62258917168563, 8.57317407052567, 8.52427228591553, 8.47586589567134, 8.42793570467514, 8.38046100926127, 8.33341933040706, 8.28678611200021, 8.24053438007832, 8.19463435852674, 8.14905303628375, 8.10375368062195, 8.05869529056289, 8.01383198392324, 7.9691123108955, 7.92447848641908, 7.87986553290485, 7.83520032413446, 7.79040052035017, 7.74537338370147, 7.70001446228808, 7.65420613006446, 7.6078159688108, 7.56069497725916, 7.51267559125967, 7.46356949759379, 7.41316522267665, 7.36122547593801, 7.30748422612498, 7.25164348712494, 7.1933697881582, 7.13229030133525, 7.06798859760072, 7, },
			{ 15, 14.861288109009, 14.7251057285664, 14.5913846733913, 14.4600591715975, 14.3310657596375, 14.204343182628, 14.0798322997636, 13.9574759945134, 13.8372190893019, 13.7190082644632, 13.6027919811709, 13.4885204081642, 13.3761453520242, 13.2656201908279, 13.1568998109647, 13.0499405469676, 12.9447001241886, 12.841137604137, 12.7392133323942, 12.6388888888936, 12.5401270405126, 12.4428916958011, 12.3471478617628, 12.2528616025759, 12.160000000149, 12.0685311164249, 11.9784239573423, 11.8896484383715, 11.8021753515426, 11.7159763339081, 11.6310238373487, 11.5472910996841, 11.4647521170105, 11.3833816172258, 11.3031550346825, 11.2240484859357, 11.1460387465366, 11.0691032288557, 10.9932199608921, 10.9183675660696, 10.8445252439971, 10.7716727522007, 10.6997903888405, 10.6288589764299, 10.5588598466036, 10.4897748259841, 10.4215862232284, 10.3542768173478, 10.287829847429, 10.2222290039063, 10.1574584215813, 10.093502674613, 10.0303467737582, 9.96797616618994, 9.90637673828231, 9.84553482182088, 9.78543720417483, 9.72607114305764, 9.66742438660421, 9.6094851996057, 9.55224239687458, 9.49568538485626, 9.43980421277153, 9.38458963475064, 9.33003318463453, 9.27612726534395, 9.22286525497068, 9.17024163204257, 9.1182521227183, 9.0668938730301, 9.01616564968064, 8.96606807333189, 8.91660388880297, 8.86777827711989, 8.81959921494126, 8.77207788751954, 8.72522916206148, 8.67907212911482, 8.63363072045536, 8.58893441286147, 8.54501902817461, 8.50192764113648, 8.45971160768893, 8.41843172772707, 8.37815955770217, 8.33897889001681, 8.30098741780931, 8.26429860554326, 8.22904378775842, 8.19537452046687, 8.16346521195375, 8.13351606221369, 8.10575634291065, 8.08044805261825, 8.05788998518127, 8.0384222523601, 8.0224313054865, 8.01035550469151, 8.00269128837522, 8, },
			{ 16, 15.8513871189105, 15.7054978854294, 15.5622584597994, 15.4215976331361, 15.2834467120186, 15.1477394090427, 15.0144117390158, 14.8834019204395, 14.7546502819622, 14.6280991735543, 14.5036928820718, 14.3813775510218, 14.2611011042371, 14.1428131732846, 14.026465028356, 13.9120095124842, 13.7994009788896, 13.6885952312542, 13.5795494668457, 13.4722222222216, 13.3665733214927, 13.2625638269239, 13.1601559917942, 13.0593132153819, 12.9599999999627, 12.8621819097296, 12.7658255315168, 12.6708984372566, 12.5773691480523, 12.4852070998276, 12.3943826104219, 12.3048668481011, 12.2166318013862, 12.1296502501431, 12.0438957378608, 11.9593425450633, 11.875965663781, 11.7937407730346, 11.7126442152517, 11.6326529735718, 11.5537446499614, 11.4758974440757, 11.3990901327986, 11.3233020503703, 11.2485130690281, 11.1747035800474, 11.1018544750831, 11.0299471276731, 10.9589633747601, 10.8888854980469, 10.8196962049935, 10.7513786092012, 10.6839162099083, 10.6172928702574, 10.5514927939445, 10.48650049978, 10.4223007936203, 10.3588787370266, 10.2962196119035, 10.2343088802364, 10.1731321379065, 10.1126750613889, 10.0529233459537, 9.99386263375968, 9.93547842998721, 9.87775600487317, 9.82068027916982, 9.76423569021112, 9.70840603532441, 9.65317428887897, 9.59852238872677, 9.54443098720107, 9.49087916117387, 9.43784407493137, 9.38530058879405, 9.33322080548495, 9.28157354521269, 9.23032373929028, 9.1794317308403, 9.12885246971085, 9.07853458717851, 9.02841933426824, 8.97843936561812, 8.92851734870927, 8.87856437595296, 8.82847815458567, 8.77814094650581, 8.72741722712199, 8.67615102889499, 8.62416293157991, 8.57124665712205, 8.51716522276339, 8.46164660109305, 8.40437883053881, 8.34500451407778, 8.28311463773434, 8.21824163367798, 8.14985160540233, 8.07733562450837, 8, },
			{ 17, 16.8414861288077, 16.6858900422901, 16.5331322462074, 16.3831360946743, 16.2358276643987, 16.0911356354569, 15.9489911782686, 15.809327846366, 15.6720814746226, 15.5371900826451, 15.4045937829723, 15.2742346938786, 15.14605685645, 15.0200061557416, 14.896030245747, 14.7740784780007, 14.6541018335909, 14.5360528583728, 14.4198856013002, 14.3055555555557, 14.1930196024865, 14.0822359580765, 13.9731641218874, 13.8657648283084, 13.7600000000093, 13.6558327034702, 13.5532271064891, 13.4521484375692, 13.3525629470647, 13.2544378700516, 13.1577413907698, 13.0624426086071, 12.9685115055421, 12.8759189149512, 12.7846364917484, 12.6946366837773, 12.6058927044003, 12.5183785062464, 12.4320687560513, 12.3469388105709, 12.2629646935158, 12.1801230734878, 12.098391242897, 12.0177470978365, 11.9381691189372, 11.8596363531784, 11.7821283967113, 11.7056253787169, 11.6301079463681, 11.5555572509766, 11.4819549354533, 11.4092831232153, 11.3375244087488, 11.2666618500614, 11.1966789633303, 11.1275597201229, 11.0592885476362, 10.9918503325246, 10.9252304289768, 10.8594146718578, 10.7943893958768, 10.7301414619386, 10.6666582920487, 10.6039279143938, 10.5419390205077, 10.4806810367839, 10.4201442129565, 10.3603197306567, 10.3011998356261, 10.2427779977848, 10.185049104004, 10.1280096892153, 10.071658212343, 10.0159953845508, 9.96102455840446, 9.90675218783118, 9.85318837018632, 9.80034748335332, 9.74824893263615, 9.69691802423128, 9.64638698438521, 9.59669614590022, 9.54789532653687, 9.50004542708416, 9.45322028043982, 9.40750878705646, 9.36301737653981, 9.31987284013279, 9.27822558428333, 9.23825336157815, 9.20016554201888, 9.1642079950576, 9.13066866098331, 9.09988389929345, 9.07224571162603, 9.04820994777507, 9.02830561533209, 9.01314542670563, 9.0034377317364, 9, },
			{ 18, 17.8315851387072, 17.6662821991521, 17.5040060326159, 17.3446745562104, 17.1882086167782, 17.0345318618712, 16.8835706175202, 16.7352537722912, 16.5895126672864, 16.4462809917359, 16.3054946838735, 16.1670918367359, 16.0310126086622, 15.8971991381989, 15.7655954631369, 15.6361474435177, 15.5088026882914, 15.3835104854917, 15.2602217357536, 15.138888888888, 15.0194658834771, 14.9019080892224, 14.7861722519668, 14.6722164412048, 14.5599999999977, 14.4494834970974, 14.3406286812462, 14.2333984374821, 14.1277567453519, 14.0236686389839, 13.9211001688623, 13.8200183652457, 13.7203912031712, 13.6221875689163, 13.5253772278875, 13.4299307938403, 13.3358196993703, 13.243016167626, 13.1514931851393, 13.0612244757715, 12.9721844756581, 12.8843483091344, 12.7976917655553, 12.7121912769514, 12.6278238964785, 12.5445672775385, 12.4623996535452, 12.3812998182157, 12.3012471062804, 12.2222213745117, 12.144202982919, 12.0671727759278, 11.9911120633636, 11.916002600968, 11.8418265701686, 11.7685665567315, 11.6962055278474, 11.6247268071352, 11.5541140469033, 11.4843511968848, 11.4154224685148, 11.3473122935975, 11.2800052760087, 11.2134861347879, 11.1477396366692, 11.0827505157226, 11.0185033773195, 10.9549825831538, 10.8921721134178, 10.8300554015507, 10.7686151361573, 10.7078330237652, 10.6476895049894, 10.5881634154322, 10.5292315811967, 10.4708683372478, 10.4130449549565, 10.3557289629843, 10.2988833432173, 10.2424655806149, 10.1864265426476, 10.130709160362, 10.0752468789744, 10.0199618412493, 9.96476276162585, 9.90954244313159, 9.85417488241018, 9.7985119006834, 9.74237922998754, 9.68557197457967, 9.62784935676303, 9.56892864454681, 9.50847814528505, 9.44610913466397, 9.381366573955, 9.31371845013604, 9.24254355312745, 9.16711748182831, 9.0865966455804, 9, },
			{ 19, 18.821684148609, 18.6466743560147, 18.4748798190186, 18.3062130177481, 18.1405895691572, 17.9779280882873, 17.8181500567728, 17.6611796982172, 17.5069438599494, 17.3553719008268, 17.2063955847749, 17.0599489795901, 16.9159683608726, 16.7743921206545, 16.6351606805262, 16.4982164090373, 16.3635035429912, 16.2309681126132, 16.1005578702065, 15.9722222222203, 15.845912164468, 15.7215802203693, 15.5991803820512, 15.4786680541082, 15.3600000000006, 15.2431342907536, 15.1280302560608, 15.0146484375059, 14.9029505438506, 14.7928994083047, 14.6844589476536, 14.5775941231228, 14.4722709029527, 14.3684562265678, 14.2661179702376, 14.165224914219, 14.0657467112304, 13.9676538563021, 13.8709176577954, 13.7755102096917, 13.6814043649791, 13.5885737101624, 13.4969925408126, 13.4066358381417, 13.3174792465862, 13.229499052334, 13.1426721628323, 13.0569760872557, 12.9723889179235, 12.8888893127441, 12.8064564787116, 12.7250701565163, 12.6447106064184, 12.5653585954791, 12.4869953864083, 12.4096027282317, 12.3331628491277, 12.2576584518604, 12.1830727123261, 12.1093892818682, 12.036592294206, 11.9646663779684, 11.8935966761137, 11.823368873736, 11.7539692361642, 11.6853846596228, 11.617602737196, 11.5506118434554, 11.4844012417415, 11.4189612189144, 11.3542832533287, 11.2903602228892, 11.2271866613574, 11.1647590725801, 11.1030763141025, 11.0421400636909, 10.9819553846835, 10.9225314088722, 10.8638821588583, 10.8060275355077, 10.7489945004549, 10.6928184885031, 10.6375450904513, 10.5832320533506, 10.5299516526172, 10.477793498907, 10.426867852303, 10.3773095273989, 10.3292824853107, 10.2829852228783, 10.2386570853461, 10.1965856470167, 10.1571153248843, 10.1206574134156, 10.0877017547422, 10.0588302878697, 10.0347327534659, 10.0162248678081, 10.0042693208745, 10, },
			{ 20, 19.8117831585163, 19.6270665128763, 19.4457536054286, 19.2677514792824, 19.0929705215322, 18.9213243147029, 18.7527294960269, 18.5871056241389, 18.4243750526132, 18.2644628099175, 18.1072964856741, 17.9528061224443, 17.8009241130812, 17.6515851031114, 17.5047258979145, 17.360285374555, 17.2182043976925, 17.078425739733, 16.9408940046622, 16.8055555555523, 16.6723584454625, 16.5412523515191, 16.4121885121333, 16.2851196670092, 16.1599999999999, 16.0367850844004, 15.9154318308612, 15.7958984374989, 15.6781443422879, 15.5621301775109, 15.4478177262307, 15.3351698806022, 15.2241506020245, 15.1147248829684, 15.0068587104151, 14.900519030883, 14.795673716844, 14.692291534606, 14.5903421134598, 14.4897959161246, 14.3906242103568, 14.2927990417298, 14.1962932074517, 14.1010802312187, 14.0071343390402, 13.9144304359295, 13.8229440834664, 13.7326514781161, 13.6435294302179, 13.5555553436279, 13.4687071958564, 13.3829635186084, 13.2983033785985, 13.2147063584428, 13.1321525374773, 13.0506224721914, 12.970097175999, 12.8905580979194, 12.8119870997258, 12.7343664308773, 12.6576787005349, 12.5819068456579, 12.5070340940475, 12.4330439208099, 12.3599199964927, 12.287646124649, 12.2162061660786, 12.1455839464496, 12.0757631431987, 12.0067271467596, 11.9384588901372, 11.8709406395189, 11.804153737209, 11.7380782862906, 11.6726927644231, 11.6079735515945, 11.5438943537937, 11.4804255010797, 11.4175330945022, 11.3551779715926, 11.2933144546304, 11.2318888394273, 11.1708375749254, 11.1100850751851, 11.0495410952742, 10.9890975909401, 10.9286249684961, 10.8679676158889, 10.8069385880731, 10.7453132994095, 10.6828220523353, 10.6191412047446, 10.5538827478574, 10.4865820313893, 10.4166833329941, 10.3435229236456, 10.2663092291376, 10.1840996295478, 10.0957733723331, 10, },
			{ 21, 20.8018821684335, 20.6074586697395, 20.4166273918483, 20.2292899408079, 20.0453514739074, 19.8647205411201, 19.6873089352799, 19.5130315500734, 19.3418062452694, 19.1735537190099, 19.0081973865749, 18.8456632652949, 18.6858798652848, 18.5287780855659, 18.3742911153037, 18.2223543400758, 18.0729052523959, 17.9258833668494, 17.7812301391183, 17.638888888885, 17.4988047264546, 17.3609244826717, 17.2251966422156, 17.0915712799099, 16.96, 16.8304358780539, 16.7028334056629, 16.5771484375004, 16.45333814074, 16.3313609467502, 16.2111765048764, 16.0927456382076, 15.9760303013332, 15.8609935397941, 15.7475994513537, 15.6358131488821, 15.5256007247721, 15.416929216852, 15.3097665757483, 15.2040816335522, 15.099844073749, 14.9970244024683, 14.8955939207955, 14.7955246982643, 14.6967895474386, 14.5993619994772, 14.5032162807679, 14.4083272905031, 14.3146705791943, 14.222222328186, 14.1309593301096, 14.0408589703195, 13.9518992093402, 13.8640585664413, 13.7773161043911, 13.6916514155735, 13.6070446096835, 13.523476303204, 13.4409276111589, 13.3593801414716, 13.2788159926744, 13.1992177556902, 13.1205685207509, 13.0428518906826, 12.9660520022789, 12.890153557732, 12.8151418687269, 12.7410029164135, 12.6677234311934, 12.595290997269, 12.5236941880034, 12.4529227395443, 12.3829677718376, 12.3138220681436, 12.2454804266827, 12.1779401007892, 12.1112013475796, 12.0452681091581, 11.9801488553443, 11.915857622723, 11.8524152917478, 11.7898511516701, 11.7282048128124, 11.6675285368441, 11.6078900690158, 11.5493760717912, 11.4920962774072, 11.4361884980179, 11.3818246566144, 11.3292180305311, 11.2786319323752, 11.2303900916353, 11.184889044493, 11.1426128904943, 11.1041508336547, 11.0702179933005, 11.041680047736, 11.0195823630426, 11.0051843613888, 11, },
			{ 22, 21.7919811783601, 21.5878508266014, 21.3875011782618, 21.1908284023295, 20.9977324262735, 20.808116767524, 20.6218883745334, 20.4389574760281, 20.2592374379063, 20.0826446280914, 19.9090982874887, 19.738520408145, 19.5708356174939, 19.4059710680131, 19.2438563326962, 19.0844233056011, 18.9276061071013, 18.7733409939703, 18.6215662735724, 18.4722222222169, 18.3252510074435, 18.1805966138218, 18.0382047722947, 17.8980228928122, 17.76, 17.6240866717064, 17.4902349804614, 17.3583984374962, 17.2285319391889, 17.1005917159747, 16.9745352834965, 16.8503213957777, 16.7279100005653, 16.6072621964756, 16.4883401920289, 16.3711072663981, 16.2555277318424, 16.1415668975962, 16.0291910354507, 15.9183673465744, 15.8090639297564, 15.7012497509542, 15.5948946140574, 15.4899691327594, 15.3864447036604, 15.284293480249, 15.183488348036, 15.0840029005583, 14.9858114161954, 14.888888835907, 14.7932107416379, 14.6987533354301, 14.6054934190498, 14.5134083741217, 14.4224761425907, 14.3326752072797, 14.2439845724824, 14.1563837441377, 14.0698527094127, 13.9843719151135, 13.8999222444684, 13.8164849914716, 13.7340418319317, 13.6525747899646, 13.5720661985158, 13.4924986518962, 13.4138549479517, 13.3361180168388, 13.2592708324761, 13.1832963019144, 13.1081771265185, 13.0338956275257, 12.9604335265586, 12.8877716695692, 12.815889679988, 12.7447655234025, 12.674374962366, 12.6046908748573, 12.5356824042804, 12.4673139018166, 12.3995436136827, 12.3323220556326, 12.2655900053677, 12.1992760290514, 12.1332934413347, 12.0675365782577, 12.0018762386532, 11.9361541217455, 11.8701760556123, 11.8037037725214, 11.7364449415389, 11.668041115696, 11.5980531886226, 11.525943882936, 11.4510567080272, 11.3725907264312, 11.2895703536957, 11.2008092842175, 11.1048674822235, 11, },
			{ 23, 22.7820801882728, 22.5682429834378, 22.3583749646576, 22.1523668638617, 21.9501133786334, 21.7515129939413, 21.55646781379, 21.3648834019814, 21.1766686305264, 20.9917355371607, 20.8099991883843, 20.6313775510264, 20.4557913697235, 20.2831640504721, 20.1134215501083, 19.9464922711064, 19.7823069618108, 19.6207986210918, 19.4619024080267, 19.3055555555498, 19.1516972884311, 19.0002687449556, 18.851212902378, 18.7044745057081, 18.56, 18.4177374653666, 18.2776365552654, 18.1396484374989, 18.0037257376413, 17.8698224851955, 17.7378940621233, 17.6078971533587, 17.4797896998183, 17.3535308532028, 17.2290809328052, 17.1064013840797, 16.985454739233, 16.8662045789116, 16.7486154961666, 16.6326530613599, 16.5182837887924, 16.4054751045961, 16.2941953159546, 16.1844135815766, 16.0760998833617, 15.9692249990983, 15.8637604764194, 15.7596786077292, 15.6569524060535, 15.5555555820465, 15.455462521758, 15.3566482655718, 15.2590884879162, 15.162759477977, 15.0676381215832, 14.973701883926, 14.8809287936811, 14.7892974283962, 14.6987869014422, 14.6093768509242, 14.521047430871, 14.4337793052894, 14.3475536458914, 14.2623521344254, 14.1781569709604, 14.0949508897494, 14.0127171848722, 13.9314397485519, 13.8511031255901, 13.7716925886636, 13.6931942401728, 13.615595148179, 13.5388835256105, 13.4630489645118, 13.388082740009, 13.313978202216, 13.2407312789812, 13.1683411176125, 13.0968109006216, 13.0261488785394, 12.9563696729143, 12.8874959143831, 12.8195602955464, 12.7526081355992, 12.6867005748624, 12.6219185426951, 12.5583676723687, 12.4961843728658, 12.4355433105045, 12.3766666047292, 12.319835103199, 12.2654021735601, 12.2138105345836, 12.1656127500403, 12.121496127374, 12.082312902626, 12.049116756915, 12.0232069014663, 12.0061811925969, 12, },
			{ 24, 23.7721791981895, 23.5486351402188, 23.3292487510145, 23.1139053253805, 22.9024943310266, 22.6949092203929, 22.4910472529943, 22.2908093279389, 22.0940998231633, 21.9008264462429, 21.7109000892828, 21.5242346939306, 21.3407471219559, 21.1603570329111, 20.9829867675197, 20.8085612365833, 20.6370078165262, 20.4682562482264, 20.3022385424736, 20.1388888888828, 19.9781435694223, 19.8199408760933, 19.6642210324877, 19.5109261186168, 19.36, 19.2113882590268, 19.0650381300537, 18.920898437496, 18.7789195360934, 18.6390532544294, 18.5012528407378, 18.3654729109269, 18.2316693990562, 18.0997995099025, 17.9698216735466, 17.8416955016891, 17.7153817464959, 17.590842260015, 17.468039956482, 17.3469387754372, 17.2275036465881, 17.1097004560813, 16.9934960141312, 16.8788580240962, 16.7657550524935, 16.6541565004287, 16.5440325760833, 16.4353542682739, 16.3280933210117, 16.2222222089767, 16.1177141138897, 16.0145429019029, 15.9126831014345, 15.8121098818982, 15.7127990331475, 15.6147269450003, 15.517870587596, 15.4222074915268, 15.3277157281368, 15.2343738894379, 15.1421610671624, 15.0510568307216, 14.9610412031011, 14.872094633967, 14.7841979688788, 14.6973324127767, 14.6114794861401, 14.52662097099, 14.4427388433428, 14.3598151879418, 14.2778320894785, 14.1967714933066, 14.1166150263, 14.0373437662503, 13.9589379449933, 13.8813765663167, 13.8046369151887, 13.7286939282616, 13.6535193885132, 13.5790808971594, 13.5053405649345, 13.4322533502052, 13.3597649546929, 13.287809166104, 13.2163045113653, 13.1451500532788, 13.0742201250367, 13.0033577518808, 12.9323664536508, 12.8610000557404, 12.788950056087, 12.7158300003267, 12.6411562028401, 12.5643240149592, 12.4845786789973, 12.4009796134802, 12.3123567457915, 12.2172572365628, 12.1138806193266, 12, },
			{ 25, 24.7622782080746, 24.5290272970101, 24.3001225373451, 24.0754437868481, 23.8548752833477, 23.6383054467572, 23.4256266921019, 23.2167352538865, 23.0115310158595, 22.809917355377, 22.6118009902588, 22.4170918368046, 22.2257028741586, 22.0375500152642, 21.8525519848181, 21.6706302020975, 21.4917086712303, 21.315713875335, 21.1425746769204, 20.9722222221873, 20.8045898504307, 20.6396130072753, 20.4772291626229, 20.3173777315414, 20.16, 20.0050390526766, 19.8524397048546, 19.7021484374581, 19.5541133345555, 19.4082840236622, 19.2646116193627, 19.1230486685094, 18.9835490982915, 18.8460681666082, 18.71056241429, 18.576989619335, 18.4453087537932, 18.3154799411924, 18.1874644169551, 18.0612244898218, 17.9367235048944, 17.813925808477, 17.6927967139141, 17.5733024693818, 17.4554102263894, 17.3390880098102, 17.22430468925, 17.1110299512041, 16.9992342726658, 16.8888888955116, 16.7799658018872, 16.6724376910088, 16.5662779562865, 16.4614606637762, 16.3579605317938, 16.2557529107824, 16.1548137650637, 16.0551196549156, 15.9566477203952, 15.8593756663344, 15.7632817490085, 15.6683447649394, 15.5745440420674, 15.4818594342517, 15.3902713202417, 15.2997606075905, 15.210308744302, 15.1218977397342, 15.0345101980997, 14.9481293684468, 14.8627392164766, 14.7783245248121, 14.6948710307943, 14.6123656129622, 14.5307965412551, 14.450153809597, 14.3704295753135, 14.2916187359528, 14.213719683083, 14.136735282265, 14.0606741423925, 13.9855522528268, 13.9113950875948, 13.8382403004857, 13.7661411653397, 13.6951709541799, 13.625428491216, 13.5570451783511, 13.4901938562502, 13.42509994983, 13.3620554489581, 13.3014363997037, 13.2437247313608, 13.1895354259289, 13.1396502549602, 13.095059571061, 13.057013956579, 13.0270879081676, 13.0072581868621, 13, },
		};
	}
}