import Link from 'next/link'

export default function Home() {
  return (
    <div>
      <h2>This is Home Page</h2><Link href="/products">click here to go to products page..</Link>
    </div>
  );
}
