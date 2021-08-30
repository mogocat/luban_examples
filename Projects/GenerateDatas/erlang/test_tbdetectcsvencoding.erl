-module(test_tbdetectcsvencoding).
-export([get_data_map/0, get_key_list/0]).
get_data_map() -> #{
	21 => #{id => 21,name => "测试编码"},
	22 => #{id => 22,name => "还果园国要"},
	23 => #{id => 23,name => "工枯加盟仍"},
	11 => #{id => 11,name => "测试编码"},
	12 => #{id => 12,name => "还果园国要"},
	13 => #{id => 13,name => "工枯加盟仍"},
	31 => #{id => 31,name => "测试编码"},
	32 => #{id => 32,name => "还果园国要"},
	33 => #{id => 33,name => "工枯加盟仍"},
	1 => #{id => 1,name => "测试编码"},
	2 => #{id => 2,name => "还果园国要"},
	3 => #{id => 3,name => "工枯加盟仍"}}.
get_key_list() ->
	[21,22,23,11,12,13,31,32,33,1,2,3].