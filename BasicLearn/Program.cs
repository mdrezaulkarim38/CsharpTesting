using System;
namespace BasicLearn;

class sample
{
    public sample()
    {
        Console.WriteLine("constructor 1 called");
    }
    public sample(int x)
    {
        int p = 2;
        int u;
        u = p + x;
        Console.WriteLine("constructor 2 called");
    }
}
class Program
{
    static void Main(string[] args)
    {
        sample s = new sample(4);
        sample t = new sample();
    
    }
}

/**
In Angular,  Will both components share the same count?

@Injectable ({ providedIn: 'root'})
export class CounterService {
    count = 0;
    increment() {this.count++;}
}

@Component({
    selector: 'app-a',
    template: `<button (click)="add()">add</button>`
})

export class AComponent {
    constructor(public cs: CounterService) {}
    add() { this.cs.increment(); }
}

@Component({
    selector: 'app-b',
    template: `<p>{{ cs.count }}</p>`
})

export class BComponent{
    constructor(public cs: CounterService) {}
}

Will not compile
No, separate instances
Yes, shared instance
Static count

*/