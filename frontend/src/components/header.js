export default function Header ({ logo }) {
    return (
        <div className="flex justify-between px-4 bg-green-200 h-16">
        
        <div className="p-4">
            <img className="w-10 h-10 " src={logo} alt="StudentFinder" />
        </div>

        <div className="p-4">
            <p className="text-lg">Hello, Anonymous User</p>

        </div>

        </div>
    )
}
