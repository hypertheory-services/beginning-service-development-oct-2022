# Beginning Services Development Class Notes

> October 2022

## Why Distributed Applications?

- Some just are. Use a web browser?
- High Availability - 
- Performance - 
- Scale 
- "Social / Team"
    - Team autonomy.

## Fundamentals Stuff

- Communications (networking)
- Coordination
    - Event-Driven Services
- Scalability
    - "Load" - anything that consumes system resources
        - CPU
        - Memory
        - Network bandwidth
    - Throughput - 
    
- Resiliency
    Can we keep going (running, handling requests) even when there are failures?
    - Site Reliability Engineering (SRC), "Chaos Engineering" "Chaos Monkey"

    - "Ports and Adapters" model -> "Attached Resources" from 12FA

# 12 Factor App 


## Service Integration Patterns

> This is just talking about when you have a bunch of services, how do they communicate with each other.

### The "Best Practices"

- Messaging (Message Queues, Event Brokers, Etc)
    - Asynchronous Service a sends a message, and some other service will process that message.
- Remote Procedure Calls (API Calls to other APIs)
    - Synchronous (service a -> service b, service b -> service a) (request response)

### Anti-Patterns (bad practices)

- Shared Databases

- Shared Libraries



## Stuff You Should Watch or Read

Jimmy Bogard (Automapper fame) - talking about his experiences at a "fictional" Texas computer company called "Bell Computers"
https://www.youtube.com/watch?v=gfh-VCTwMw8&themeRefresh=1

### Pat Helland's "Data on the Inside Data on the Outside"
https://queue.acm.org/detail.cfm?id=3415014