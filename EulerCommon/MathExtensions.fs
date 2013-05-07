namespace AshleyIngram.Euler.Common.MathExtensions

module Math =
    /// <summary>
    /// Prime Sieve
    /// Given a number, find all primes up to that point
    /// </summary>
    /// <param name="max">Find primes up to this number</param>
    /// <returns>A list of prime numbers</returns>
    let PrimeGenerator (max: uint64) =
        // Optimization - The highest factor of a non-prime is <= the sqrt of the non-prime
        // TODO: This can still run out of memory... should probably try/catch
        let nums = [1UL .. uint64(System.Math.Ceiling(System.Math.Sqrt(float(max))))]

        // Filter out any numbers which are divisible by i (and therefore not primes)
        let sieve(numList: uint64 list, i: uint64) = if i <> 0UL && i <> 1UL && (List.exists(fun e -> e = i) numList) 
                                                        then numList |> List.filter(fun x -> x = i || x % i <> 0UL) 
                                                        else numList;
    
        // Recursively apply the sieve by increasing i until its equal to the highest number
        let rec applySieve (unfilteredList: uint64 list, i: uint64) =
            let filteredList = sieve(unfilteredList, unfilteredList.Item(int(i)));
            if int(i) >= filteredList.Length - 1 then filteredList else applySieve(filteredList, i+1UL);
        
        applySieve(nums, 0UL)

    /// <summary>
    /// Generate the Fibonacci Sequence up to a given point
    /// </summary>
    /// <param name="list">Current list of fibonacci numbers</param>
    /// <param name="stop">Point at which to stop calculating fibonacci sequence</param>
    /// <returns>List of fibonacci numbers</returns>
    let rec GenerateFibonacci (list: List<int>, stop): List<int> =
        // TODO: Use lazy loading/unfold?
        let newNum = if (list.Length > 2) then list.Item(list.Length - 2) + list.Item(list.Length - 1) else 1

        if (newNum >= stop) then
            list
        else
            GenerateFibonacci(list @ [newNum], stop)