return {
    id = 10002,
    name = "random move",
    desc = "demo behaviour tree haha",
    blackboard_id = "demo",
    root = {
        _name = 'Sequence',
        id = 1,
        node_name = "test",
        decorators = {
            {
                _name = 'UeLoop',
                id = 3,
                node_name = "",
                flow_abort_mode = 2,
                num_loops = 0,
                infinite_loop = true,
                infinite_loop_timeout_time = -1,
            },
        },
        services = {
        },
        children = {
            {
                _name = 'UeWait',
                id = 30,
                node_name = "",
                decorators = {
                },
                services = {
                },
                ignore_restart_self = false,
                wait_time = 1,
                random_deviation = 0.5,
            },
            {
                _name = 'MoveToRandomLocation',
                id = 75,
                node_name = "",
                decorators = {
                },
                services = {
                },
                ignore_restart_self = false,
                origin_position_key = "x5",
                radius = 30,
            },
        },
    },
}