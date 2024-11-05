export default function SearchResults({ data }) {

    return (
        <div className="flex flex-col items-center justify-start">
            <p>Search Results for</p>
            <div className="text-center">
                <p>{data.id}</p>
                <p>{data.firstName}</p>
                <p>{data.lastName}</p>
                <p>{data.userType}</p>
                <p>{data.dateCreated}</p>
            </div>
        </div>
    );
    
}
