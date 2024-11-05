export default function SearchBar ({ handleSubmit, searchString, onSearchChange }) { 

    return (
    <form onSubmit={handleSubmit} className="flex justify-center py-10">
        
        <div className="w-3/5 mr-4">
            <label className="relative block">
            <span className="sr-only">Search</span>
            <span className="absolute inset-y-0 left-0 flex items-center pl-2">
            <svg className="h-5 w-5 fill-slate-300" viewBox="0 0 20 20"></svg>
            </span>
            <input className="placeholder:text-slate-400 block bg-white w-full border border-slate-300 rounded-md py-4 pl-5 pr-3 shadow-sm focus:outline-none focus:border-sky-300 focus:ring-sky-500 focus:ring-1 sm:text-sm"
                placeholder="Search Student by ID or Name..." 
                type="text"
                name="search"
                value={searchString}
                onChange={onSearchChange}
        />
        </label>
    </div>
        
        <div className="2/5">
            <input type="submit" className="bg-green-400 text-white py-4 rounded-md w-full p-4" value="Search" />
        </div>
        
        </form>
    )
}
